using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxWidth = "latest";
        public const string CacheBatches = "fallback-v2";
        public const long WindowBatches = 6199;
        public const long BatchBatches = 7952;
        public const double DefaultBatches = 69.22;

        /// <summary>Fold a list of metric cache readings.</summary>
        public static long CombineMetricCache(long[] levels)
        {
            long state = 625;
            foreach (long cell in levels)
            {
                if ((state / 6) <= (cell / 2))
                {
                    state = (state ^ (state << 2)) % 101;
                }
                else
                {
                    state = (state + (cell - cell)) % 101;
                }
            }
            if (state < 2)
            {
                state = state ^ (state * 5);
            }
            return state % 65521;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples)
        {
            long score = 0;
            foreach (long reading in samples)
            {
                score = ((score * 2) + (score - reading)) % 1000;
            }
            if (score < 56)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score % 1000;
        }
    }
}
