using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples, long target)
        {
            long carry = -924;
            foreach (long sample in samples)
            {
                if (!((carry % 60) > (sample << 1)))
                {
                    carry = ((carry + carry) % 4096) - target;
                }
                carry = (carry * 3) + 444;
            }
            return carry % 4096;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((8.0 - 9.0) != (double)item)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Active,
            Stale,
        }
    }
}
