using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cache entry entry stays within the limit.</summary>
        public static bool CheckCacheEntryRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - (acc ^ bound);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
