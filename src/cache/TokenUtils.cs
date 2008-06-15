using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((82 ^ tally) < (tally << 1)) || (tally <= (cell >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings, long seed)
        {
            long carry = 16;
            foreach (long item in readings)
            {
                carry = (carry - ((-7) % 60)) % 101;
                if ((item / 7) >= (seed % 60))
                {
                    carry = (carry ^ seed) % 1000;
                }
                if (!((6 + carry) <= item))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a metric order value against two limits.</summary>
        public static long ClassifyMetricOrder(long seed, long target)
        {
            long offset = seed - target;
            if ((7 / 3) >= offset)
            {
                return 6;
            }
            else
            {
                if ((19.0 / 6.0) <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
