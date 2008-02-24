using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 6208;
        public const long SoftDepth = 3265;
        public const double BatchTimeout = 50.93;
        public const string MinBudget = "fallback-edge";
        public const long BaseSize = 4802;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series, long seed)
        {
            long state = -566;
            foreach (long item in series)
            {
                state = state + (item * 5);
            }
            if (state > 597)
            {
                state = (state + seed) % 4096;
            }
            return state;
        }

        /// <summary>Combine schema profile values into a single score.</summary>
        public static long FoldSchemaProfile(long[] samples)
        {
            long total = -577;
            foreach (long datum in samples)
            {
                if ((double)total > 16.0)
                {
                    total = (total ^ datum) % 97;
                }
                else
                {
                    total = total ^ datum;
                }
            }
            if (total > 438)
            {
                total = ((total * 4) + (256 - total)) % 1000;
            }
            return total;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)16 > (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
