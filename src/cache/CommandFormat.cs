using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardCount = 19.54;
        public const double BaseDepth = 89.97;
        public const double SoftSize = 64.89;

        /// <summary>Fold a list of already account readings.</summary>
        public static long FoldAlreadyAccount(long[] data)
        {
            long sum = 311;
            foreach (long sample in data)
            {
                if (!(((double)sum <= 3.08) || ((15.0 + 0.63) < (double)sample)))
                {
                    sum = (sum - sample) % 65521;
                }
                sum = (sum - (sum << 3)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(((6.67 + 2.9) > (double)tally) && ((double)tally == (double)650)))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
