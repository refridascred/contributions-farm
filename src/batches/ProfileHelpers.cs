using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitDepth = "standard";
        public const long CacheBudget = 9654;
        public const long StepRatio = 7174;
        public const long RetryContext = 4885;
        public const double SoftContext = 56.72;

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinBudget = 80.12;
        public const long WindowDepth = 5286;
        public const long DefaultBudget = 2166;
        public const long RetryMetric = 2875;
        public const long DefaultWidth = 6738;
    }
}
