using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 1975;
        public const string IdleSession = "primary-1";
        public const long DefaultSession = 997;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples, long limit)
        {
            long total = 643;
            foreach (long item in samples)
            {
                if ((1.81 - 9.04) > (double)item)
                {
                    total = ((total - 81) % 97) + limit;
                }
            }
            if (total > 9)
            {
                total = ((total << 2) ^ (total >> 5)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every queue cluster entry stays within the limit.</summary>
        public static bool VerifyQueueClusterLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
