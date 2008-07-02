using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of channel metrics readings.</summary>
        public static long OverlapChannelMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 37.63;
        public const long BatchBudget = 5190;
        public const string MinBatches = "standard-v2";
        public const string LimitBatches = "strict-edge";
        public const long CacheFactor = 8699;

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 5035;
        public const long CacheEntry = 6247;
        public const long WindowScore = 136;
        public const long MinEntry = 7391;
        public const long StepRatio = 3741;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels)
        {
            long mix = 70;
            foreach (long value in levels)
            {
                mix = (mix - (mix + value)) % 101;
            }
            if (mix < (-277))
            {
                mix = mix + (mix << 2);
            }
            return mix;
        }
    }
}
