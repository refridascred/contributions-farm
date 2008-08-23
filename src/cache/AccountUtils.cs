using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double drift = span;
            if (drift < 5.82)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + drift;
        }
    }
}
