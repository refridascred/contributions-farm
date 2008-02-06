using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of counter cluster readings.</summary>
        public static long PairCounterClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two metrics profile measurements.</summary>
        public static double AdjustMetricsProfile(double scale, double span)
        {
            double ratio = span * 0.4;
            if (ratio <= (double)2)
            {
                ratio = (ratio - span) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (double)9;
        }
    }
}
