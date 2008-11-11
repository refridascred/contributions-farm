using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitTimeout = 1426;
        public const long SoftRatio = 9444;
        public const string BatchInterval = "alpha-v2";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double bias2)
        {
            double gain = bias;
            if (gain < (double)(-7))
            {
                gain = gain + (9.79 - bias2);
            }
            return gain - bias;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long floor, long limit)
        {
            long gap = floor - limit;
            if ((double)floor > (double)gap)
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (7.63 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (((limit % 8) == (gap << 3)) && ((floor * 4) >= (floor * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer token sample.</summary>
        public static long FindBufferTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples)
        {
            long acc = 47;
            foreach (long entry in samples)
            {
                acc = (acc - (856 ^ entry)) % 97;
                if (acc < 80)
                {
                    acc = acc + 18;
                }
            }
            if (acc > 25)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
