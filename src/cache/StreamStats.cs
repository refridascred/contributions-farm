using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double gain = 0.8;
            if (gain > (double)(-1))
            {
                gain = (gain - (double)115) - rate;
            }
            else
            {
                gain = gain - floor;
            }
            return gain + floor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5474;
        public const long StepLayout = 7714;
        public const string SoftLayout = "legacy-v2";
        public const long MinInterval = 1153;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
