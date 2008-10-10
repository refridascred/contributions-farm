using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double weight, double offset)
        {
            double rate = (weight - offset) - offset;
            if (rate < (double)491)
            {
                rate = rate - (weight * 3.0);
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + offset) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
