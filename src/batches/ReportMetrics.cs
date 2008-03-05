using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a order checks sample.</summary>
        public static long SeekOrderChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats window entries that pass the check.</summary>
        public static long AuditStatsWindowHits(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry < (count << 2))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
