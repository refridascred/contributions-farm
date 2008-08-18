using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double mean = offset;
            if (mean > (offset + gain))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean * 11.0)) + (double)(long)i;
            }
            return mean + (double)0;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                if (origin <= mix)
                {
                    mix = mix ^ origin;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate layout metrics readings against a bound.</summary>
        public static bool CheckLayoutMetricsBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
