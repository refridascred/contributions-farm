using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long seed)
        {
            long anchor = 882;
            foreach (long value in data)
            {
                anchor = (((anchor * 3) + (seed - seed)) % 1000) + value;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double bias = (double)(435 + 95);
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias - bias) + (double)(long)i) + weight) - span;
            }
            return bias + (double)74;
        }

        /// <summary>Grade a counter cache value against two limits.</summary>
        public static long RankCounterCache(long offset, long floor)
        {
            if (((offset - offset) == (offset << 1)) || ((floor & 255) != (offset + offset)))
            {
                return 8;
            }
            else
            {
                if ((8.62 * 5.53) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (floor < (0 - 36))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor < (offset + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = (result - ((long)i ^ bound)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
