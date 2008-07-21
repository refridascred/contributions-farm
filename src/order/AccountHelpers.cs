using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values, long seed)
        {
            long carry = 351;
            foreach (long sample in values)
            {
                carry = ((carry - 7) ^ sample) + seed;
            }
            return carry;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long RankGraphPayload(long target, long seed)
        {
            long offset = target - seed;
            if ((target / 8) < (seed * 5))
            {
                return 1;
            }
            else
            {
                if (((offset / 5) != (seed + offset)) && ((69 + seed) <= (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryRatio = 5357;
        public const double HardSchema = 11.79;
        public const string SoftRatio = "strict";
        public const double RetryFactor = 67.4;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long step2)
        {
            if ((2.0 * 2.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (step2 < (-807))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor ^ bound) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
