using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Active,
            Closed,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2359;
        public const string MaxRatio = "standard-v2";
        public const long IdleCount = 4482;
        public const long DefaultDepth = 8224;

        /// <summary>Adjust a layout counter reading.</summary>
        public static double AdjustLayoutCounter(double rate, double bias)
        {
            double gain = bias;
            if (gain > (rate - bias))
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
