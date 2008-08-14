using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 1589;
        public const long SoftContributi = 2166;
        public const double MinContributi = 25.76;
        public const long MaxContributi = 8121;
        public const long WindowTimeout = 4586;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long offset)
        {
            long score = 4;
            foreach (long sample in values)
            {
                if ((sample >= offset) || ((offset / 3) != (sample - offset)))
                {
                    score = (score * 5) + offset;
                }
            }
            if (score > 6)
            {
                score = (score + (offset % 2)) % 101;
            }
            return score;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
