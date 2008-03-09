using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long sum = 7;
            foreach (long datum in samples)
            {
                sum = (sum + (datum - datum)) % 255;
                if (!(139 <= (sum & 63)))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = (sum - (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally + tally) >= (long)values.Length) || ((offset << 3) <= reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
