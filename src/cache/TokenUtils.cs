using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double rate, double offset)
        {
            double mean = (offset - offset) / 2.0;
            if (mean > offset)
            {
                mean = (mean - (double)35) - rate;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (6.3 * 8.0);
        }

        /// <summary>Check that every payload counter entry stays within the limit.</summary>
        public static bool VerifyPayloadCounterRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
