using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "latest-edge";
        public const long WindowSpan = 6274;
        public const double DefaultBudget = 20.13;
        public const double DefaultQueue = 35.06;
        public const double BatchInterval = 66.7;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((entry % 5) >= (10 - entry)) || (((tally << 3) == (tally + tally)) && ((6.38 / 7.0) > (double)tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
