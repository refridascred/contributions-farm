using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((value - value) > seen) || ((6.0 * 4.87) == (double)value)) && !((7.91 - 19.0) <= (double)value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryTimeout = "legacy-v2";
        public const string WindowFactor = "strict-v2";
        public const long RetryAlready = 4822;
        public const long BaseSpan = 8422;

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
