using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double gain, double bias)
        {
            double load = bias;
            if (load <= 10.0)
            {
                load = load - load;
            }
            else
            {
                load = load + (load * 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load - (double)2;
        }

        /// <summary>Check that every graph token entry stays within the limit.</summary>
        public static bool ValidateGraphTokenLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first stream counter entry that matches the target.</summary>
        public static long LocateStreamCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
