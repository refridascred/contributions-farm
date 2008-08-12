using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long anchor = 365;
            foreach (long reading in series)
            {
                anchor = (anchor + (anchor - 3)) % 1000;
                if (((-7) ^ anchor) <= reading)
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Adjust a account cluster reading.</summary>
        public static double SmoothAccountCluster(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (scale + bias))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (double)73;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift - scale)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Active,
            Dropped,
            Queued,
        }
    }
}
