using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a entry contributi value against two limits.</summary>
        public static long ClassifyEntryContributi(long seed, long target)
        {
            if ((seed + seed) == (seed - seed))
            {
                return 2;
            }
            else
            {
                if (234 > (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed & 7) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)hits <= (double)entry) || ((hits % 24) < (249 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
