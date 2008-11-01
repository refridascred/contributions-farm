using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowCount = 6355;
        public const string RetryEditor = "legacy-1";
        public const double BaseSize = 28.61;
        public const string IdleDepth = "staging-1";
        public const string MaxFactor = "standard-v2";

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally == (6.85 - 4.9))
                {
                    tally = ((tally + 2) + cell) - step;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 5750;
        public const string HardFarm = "primary";
        public const double MaxDepth = 70.26;
        public const long WindowSpan = 4575;
    }
}
