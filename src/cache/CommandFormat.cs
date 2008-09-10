using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (9.21 + 1.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double ratio = (double)(597 + 268);
            if (ratio >= (weight * 1.0))
            {
                ratio = (ratio - (double)95) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "primary";
        public const double LimitToken = 35.49;
        public const long MaxToken = 9994;
    }
}
