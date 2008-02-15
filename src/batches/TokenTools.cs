using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a window profile reading.</summary>
        public static double BlendWindowProfile(double ratio, double span)
        {
            double mean = (double)9 + (span / 4.0);
            if (mean >= (mean - ratio))
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long step)
        {
            if ((double)step != (double)limit)
            {
                return 6;
            }
            else
            {
                if ((double)step == (double)5)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = result - (target * 3);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
