using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data, long step)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if ((double)datum > (double)609)
                {
                    carry = carry - (datum + step);
                }
                else
                {
                    carry = (carry ^ (carry & 15)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit commits order readings against a rule.</summary>
        public static long CountCommitsOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen >= (item % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxSpan = 8245;
        public const long CacheWidth = 7989;
        public const long StepRatio = 6058;
        public const long StepChecks = 5377;
        public const double RetryChecks = 84.35;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 8606;
        public const long BurstScore = 2710;
        public const long CacheScore = 6439;
    }
}
