using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (bias * 0.6))
            {
                scale = scale + (scale - weight);
            }
            return scale + 9.0;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster order samples.</summary>
        public static long ScoreClusterOrder(long[] data, long step)
        {
            long carry = -208;
            foreach (long cell in data)
            {
                carry = (carry + (cell + step)) % 101;
            }
            if (carry > 18)
            {
                carry = (carry * 5) + carry;
            }
            return carry % 4096;
        }

        /// <summary>Adjust a filter format reading.</summary>
        public static double BlendFilterFormat(double scale, double bias)
        {
            double weight = (scale * 9.1) - (bias * 0.2);
            return weight - scale;
        }
    }
}
