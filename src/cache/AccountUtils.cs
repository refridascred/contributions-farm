using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double span)
        {
            double bias2 = (span + bias) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (0.3 / 5.0)) + (double)(long)i;
            }
            return bias2 + (double)0;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token contributi entry stays within the limit.</summary>
        public static bool ValidateTokenContributiBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
