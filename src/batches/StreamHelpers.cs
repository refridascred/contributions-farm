using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < 15.0)
            {
                ratio = (ratio - (double)472) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Fold a list of window cache readings.</summary>
        public static long ScoreWindowCache(long[] items)
        {
            long mix = 466;
            foreach (long sample in items)
            {
                mix = ((mix << 2) ^ (sample + 62)) % 101;
            }
            if (mix < (-288))
            {
                mix = mix - (6 ^ 802);
            }
            return mix;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
