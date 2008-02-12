using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long seed)
        {
            long prev = target + seed;
            if (((double)prev < (9.0 - 9.0)) || ((prev ^ seed) != (seed ^ target)))
            {
                return 1;
            }
            else
            {
                if ((seed * 2) > (prev / 6))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
