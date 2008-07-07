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

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
