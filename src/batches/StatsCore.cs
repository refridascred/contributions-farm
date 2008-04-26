using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Failed,
            Queued,
        }

        /// <summary>Count the account checks entries that pass the check.</summary>
        public static long AuditAccountChecksGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)381 > (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepSize = 3746;
        public const long SoftBatches = 8668;
        public const long MinLevel = 7544;
        public const double BurstBatches = 44.89;

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5292;
        public const long BaseMetric = 9781;
        public const string WindowMetric = "local-1";
        public const long DefaultMetric = 8774;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
