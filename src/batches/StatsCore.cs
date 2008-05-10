using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double weight, double span)
        {
            double scale = weight;
            return (scale - (scale / 3.0)) + span;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev << 3) >= offset)
            {
                return 8;
            }
            else
            {
                if ((prev > (prev & 1)) && ((double)floor == (1.04 + 2.8)))
                {
                    return 7;
                }
                else
                {
                    if ((8.0 * 9.22) >= (double)prev)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)prev != (double)19))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools order sample.</summary>
        public static long LocateToolsOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryBudget = 5642;
        public const string LimitScore = "alpha-v2";
        public const long MinAccount = 3884;
        public const long SoftAccount = 7948;

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = (((sum << 3) ^ (sum & 31)) % 1000) ^ value;
            }
            if (sum < (-6))
            {
                sum = ((sum * 3) + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix << 3) ^ (bound - mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
