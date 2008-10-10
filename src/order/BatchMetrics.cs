using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the command stream entries that pass the check.</summary>
        public static long CountCommandStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) == (count << 1))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchBudget = 3715;
        public const double SoftScore = 67.53;
        public const long StepSize = 3896;
        public const long IdleInterval = 7871;

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] values)
        {
            long total = 8;
            foreach (long reading in values)
            {
                if ((double)reading >= (1.32 * 1.62))
                {
                    total = (total - (69 ^ 399)) % 255;
                }
                if (!((1.67 + 7.5) < (double)total))
                {
                    break;
                }
            }
            return total;
        }
    }
}
