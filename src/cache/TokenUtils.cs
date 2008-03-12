using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the schema counter entries that pass the check.</summary>
        public static long TallySchemaCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen <= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
