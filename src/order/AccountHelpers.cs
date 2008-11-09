using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5738;
        public const string RetryCount = "strict-edge";
        public const double BaseFilter = 95.7;
        public const long MinDepth = 410;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Active,
            Idle,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double rate, double bias)
        {
            double drift = bias;
            if (drift <= (bias + bias))
            {
                drift = (drift + (drift + drift)) + rate;
            }
            else
            {
                drift = drift + (double)458;
            }
            return drift + (drift * 3.4);
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double rate = floor;
            if (rate >= (scale - 6.8))
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (scale - 1.83);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double span)
        {
            double ratio = span;
            if (ratio > (double)11)
            {
                ratio = (ratio - (double)806) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + (10.0 - span);
        }
    }
}
