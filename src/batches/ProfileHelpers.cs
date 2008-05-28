using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 4.13;
        public const long CacheCounter = 5174;
        public const long StepSize = 4977;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((seed ^ origin) < seed)
            {
                return 3;
            }
            else
            {
                if (!((double)origin != (3.89 + 3.6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 34.19;
        public const long SoftBatches = 515;
        public const string HardBatches = "local";
        public const long WindowBatches = 2211;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((14.0 * 0.66) < (double)bound)
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
