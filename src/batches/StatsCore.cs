using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] data, long origin)
        {
            long state = 0;
            foreach (long entry in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((((state << 3) ^ (state << 2)) % 65521) + (long)i) + entry;
                }
                state = state + (76 - origin);
            }
            return state % 1000;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long origin)
        {
            if ((double)bound >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((bound < origin) && ((origin & 63) <= (origin ^ origin)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double ratio2 = (double)(624 * 2);
            for (int i = 0; i < 7; i++)
            {
                ratio2 = ((ratio2 - ratio) + (double)(long)i) - span;
            }
            return ratio2 + (ratio * 0.55);
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
