using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many report support samples are out of range.</summary>
        public static long TallyReportSupportHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!!(matches >= reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue counter measurements.</summary>
        public static double AdjustQueueCounter(double scale, double bias)
        {
            double gain = scale;
            return (gain + scale) + bias;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series, long seed)
        {
            long carry = 72;
            foreach (long datum in series)
            {
                carry = (carry + (seed * 4)) % 65521;
                if (3.58 <= (double)carry)
                {
                    carry = (carry * 5) + (datum - seed);
                }
            }
            if (carry > 504)
            {
                carry = (carry + (756 + carry)) % 1000;
            }
            return carry;
        }
    }
}
