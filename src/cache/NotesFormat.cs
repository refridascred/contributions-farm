using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first tools profile entry that matches the target.</summary>
        public static long SeekToolsProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double load = (weight / 6.0) - bias;
            return load - (bias - load);
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long origin)
        {
            if ((seed >> 5) < seed)
            {
                return 6;
            }
            else
            {
                if (seed <= (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
