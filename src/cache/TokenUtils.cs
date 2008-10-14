using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Paused,
            New,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)cell <= (7.9 + 11.0)) || !((cell + 9) < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Draft,
            Locked,
            Idle,
            Failed,
        }
    }
}
