using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of format stream readings.</summary>
        public static long CompareFormatStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= 7.8) || (((double)cell == (5.6 * 1.12)) || ((89 ^ 1) < cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Dropped,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 18.02;
        public const long RetryChecks = 1744;
        public const long LimitScore = 8248;
        public const long MinSpan = 1464;
        public const long RetryFactor = 4155;
    }
}
