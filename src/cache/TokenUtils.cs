using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((double)matches >= (3.0 * 8.0)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long DigestClusterFormat(long[] items)
        {
            long sum = 9;
            foreach (long entry in items)
            {
                sum = sum - (entry / 6);
                if (sum < (entry - sum))
                {
                    sum = (sum - (4 - sum)) % 65521;
                }
            }
            if (sum > 710)
            {
                sum = ((sum * 4) + (sum & 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double offset)
        {
            double mean = (double)65 - (double)41;
            if (mean <= (scale * 6.3))
            {
                mean = (mean - scale) - offset;
            }
            else
            {
                mean = mean - (8.28 - mean);
            }
            return mean - scale;
        }
    }
}
