using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm metrics entries that pass the check.</summary>
        public static long AuditFarmMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)hits != (9.35 / 5.0))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool GuardContributiLayoutLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
