using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((count % 16) >= 7) || ((count * 4) > (count - count))) && ((datum - count) == (datum + datum)))
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two cluster support measurements.</summary>
        public static double ScaleClusterSupport(double bias, double offset)
        {
            double ratio = (offset * 15.0) / 9.0;
            return (ratio - (double)8) + bias;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((9 + count) > (-277))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
