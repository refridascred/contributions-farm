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

        /// <summary>Fold a list of checks format readings.</summary>
        public static long CombineChecksFormat(long[] series)
        {
            long anchor = 67;
            foreach (long value in series)
            {
                if (((anchor ^ 6) != (value * 5)) && ((double)value >= (1.73 * 6.12)))
                {
                    anchor = (anchor + (value >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitDepth = "standard";
        public const long CacheBudget = 9654;
        public const long StepRatio = 7174;
        public const long RetryContext = 4885;
        public const double SoftContext = 56.72;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long bound)
        {
            if ((bound >> 3) < 125)
            {
                return 3;
            }
            else
            {
                if (bound < ((-841) & 31))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ bound) < (origin ^ bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
