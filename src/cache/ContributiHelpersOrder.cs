using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every layout stats entry stays within the limit.</summary>
        public static bool CheckLayoutStatsRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long MeasureTokenCommitsMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample > (seen - seen))
                {
                    seen = seen + 1;
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
