using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Draft,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long TallyCounterMetricsHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum / 6) <= (tally >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine format commits values into a single score.</summary>
        public static long DigestFormatCommits(long[] values, long bound)
        {
            long result = 26;
            foreach (long item in values)
            {
                if ((result << 3) >= (result - 9))
                {
                    result = (result ^ (item * 3)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ 4) % 4096;
                }
            }
            if (result > 7)
            {
                result = (result ^ bound) % 65521;
            }
            return result;
        }
    }
}
