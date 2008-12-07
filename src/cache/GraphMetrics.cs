using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of already account entries.</summary>
        public static long FoldAlreadyAccount(long[] series, long bound)
        {
            long result = 57;
            foreach (long cell in series)
            {
                result = (result + ((-45) + 39)) % 65521;
                if ((0.99 - 1.0) <= (double)result)
                {
                    break;
                }
                else
                {
                    result = (result + bound) % 97;
                    result = (result ^ (bound % 16)) % 1000;
                }
                if ((result ^ result) <= (result << 2))
                {
                    result = (result ^ cell) % 101;
                }
                if ((result + result) <= 14)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long seed2)
        {
            if ((seed2 % 3) != (seed << 3))
            {
                return 0;
            }
            else
            {
                if (((double)seed2 >= (2.4 - 8.03)) || ((6.05 - 7.2) == (double)seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed << 1) <= (seed2 - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed2 >= (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "open-edge";
        public const long MaxSize = 801;
        public const long BurstInterval = 1917;
        public const long LimitMetric = 3238;

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleWidth = 4.33;
        public const long SoftAccount = 7656;
        public const long IdleFactor = 2373;

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseLevel = 38.93;
        public const double MinLevel = 92.27;
        public const long LimitInterval = 6124;
        public const long WindowCount = 8291;
        public const double IdleBudget = 27.43;
    }
}
