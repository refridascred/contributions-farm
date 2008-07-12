using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] series, long target)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((sample + 8) >= (total - total))
                {
                    total = (total ^ (3 << 3)) - target;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "open-v2";
        public const long HardFactor = 9067;
        public const long BaseWidth = 7471;
        public const long StepSpan = 3299;
        public const long MinSpan = 6635;

        /// <summary>Scale a support report figure with a bias.</summary>
        public static double AdjustSupportReport(double weight, double span)
        {
            double scale = (double)55 + 8.4;
            if (scale > (span + scale))
            {
                scale = scale - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (span + weight)) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
