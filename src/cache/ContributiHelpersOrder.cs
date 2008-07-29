using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 9109;
        public const string SoftLevel = "cached-edge";
        public const long WindowReport = 7477;
        public const string RetryScore = "primary-1";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream queue readings.</summary>
        public static long CompareStreamQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
