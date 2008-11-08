using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] samples, long offset)
        {
            long acc = 2;
            foreach (long value in samples)
            {
                if (!((double)offset == (12.0 + 10.0)))
                {
                    acc = ((acc << 3) ^ (value + (-45))) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) > (long)data.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
