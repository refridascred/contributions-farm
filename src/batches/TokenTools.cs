using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell ^ 579) > (hits - hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of schema filter readings.</summary>
        public static long TotalSchemaFilter(long[] items)
        {
            long result = 976;
            foreach (long cell in items)
            {
                result = (result - (cell % 8)) % 255;
                if ((cell >> 5) < (53 << 1))
                {
                    result = result + 28;
                }
            }
            return result;
        }
    }
}
