using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((557 + item) >= (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + count) < (sample / 2))
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next commits channel value.</summary>
        public static double ProjectCommitsChannel(double bias, double span)
        {
            double gain = (double)0 * 17.0;
            return ((gain + (gain / 4.0)) + bias) + span;
        }
    }
}
