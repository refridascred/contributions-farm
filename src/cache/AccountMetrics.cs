using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSize = 3853;
        public const string BatchBudget = "staging-1";
        public const long MaxFactor = 5709;
        public const long HardFilter = 1286;
        public const string CacheFilter = "local-v2";

        /// <summary>Locate a profile context reading by value.</summary>
        public static long FindProfileContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double load = offset;
            if (load < gain)
            {
                load = load + (gain * 0.49);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load + gain)) + (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Synced,
            Pending,
            Paused,
        }
    }
}
