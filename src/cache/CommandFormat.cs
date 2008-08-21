using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double weight, double bias)
        {
            double gain = weight;
            return (gain + gain) + bias;
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long TallyBatchMetricMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count >> 5) > (5 >> 3)) || !((165 - 3) == (origin + 3)))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
