using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Idle,
            New,
            Retry,
            Done,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(11.0 < (double)sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank tools batches input into a small class.</summary>
        public static long BucketToolsBatches(long origin, long target)
        {
            if (((target & 7) <= target) || ((0.3 - 7.1) <= (double)target))
            {
                return 2;
            }
            else
            {
                if ((target >> 4) != (origin - 973))
                {
                    return 8;
                }
                else
                {
                    if (origin < (target % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftSpan = 9567;
        public const long BurstLevel = 2193;
        public const double IdleCounter = 77.99;
        public const long StepCounter = 3359;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
