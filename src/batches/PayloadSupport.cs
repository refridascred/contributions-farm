using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account commits entries that pass the check.</summary>
        public static long CountAccountCommitsHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((69 >> 5) <= origin) && ((origin >= (9 >> 1)) || ((value / 4) >= (value * 3))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2389;
        public const double IdleDepth = 22.73;
        public const long IdleNotes = 6809;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
