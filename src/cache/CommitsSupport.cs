using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = total - (total + 306);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every window stats entry stays within the limit.</summary>
        public static bool GuardWindowStatsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stream stats readings.</summary>
        public static long WeighStreamStats(long[] data, long bound)
        {
            long sum = 9;
            foreach (long item in data)
            {
                sum = sum + ((long)data.Length % 8);
                sum = sum ^ (item + sum);
                if (bound <= (57 >> 3))
                {
                    break;
                }
            }
            if (sum < 38)
            {
                sum = (sum + (bound & 1)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first buffer counter entry that matches the target.</summary>
        public static long SeekBufferCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
