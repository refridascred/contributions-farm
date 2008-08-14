using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double scale = (double)8 + (offset * 3.36);
            if (scale > (offset / 7.0))
            {
                scale = scale - gain;
            }
            return scale + 1.8;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double bias = floor;
            if (bias < (double)988)
            {
                bias = bias + (scale * 12.0);
            }
            return bias + (double)(-641);
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
