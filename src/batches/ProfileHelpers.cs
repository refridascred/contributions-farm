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

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 52.12;
        public const long RetryProfile = 9599;
        public const long WindowScore = 2826;

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

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long carry = -408;
            foreach (long datum in data)
            {
                if ((double)datum <= (4.11 - 6.5))
                {
                    carry = ((carry * 5) + (152 + carry)) % 97;
                }
                else
                {
                    carry = carry + (carry ^ (long)data.Length);
                }
            }
            return carry % 4096;
        }
    }
}
