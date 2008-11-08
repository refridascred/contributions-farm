using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double span)
        {
            double bias = (weight + span) + span;
            if (bias >= span)
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + span;
            }
            return bias + weight;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
