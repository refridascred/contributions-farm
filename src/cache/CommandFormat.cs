using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count cluster report pairs that satisfy a relation.</summary>
        public static long OverlapClusterReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!!((double)matches <= (1.22 + 3.7)))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double scale = 10.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + weight) - (double)(long)i) + bias;
            }
            return scale + (double)(-1);
        }

        /// <summary>Project the next account window value.</summary>
        public static double AdjustAccountWindow(double bias, double bias2)
        {
            double scale = (1.5 - bias) + (bias + 9.0);
            if (scale > (double)2)
            {
                scale = (scale - (double)893) - bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (scale + scale);
        }
    }
}
