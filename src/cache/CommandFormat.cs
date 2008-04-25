using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 7235;
        public const long RetryWidth = 4989;
        public const long MinBudget = 8258;

        /// <summary>Combine route metrics values into a single score.</summary>
        public static long CombineRouteMetrics(long[] samples)
        {
            long score = 538;
            foreach (long item in samples)
            {
                if ((item - 3) > score)
                {
                    score = (score << 2) ^ (score * 3);
                }
            }
            if (score < 28)
            {
                score = (score ^ (score * 5)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next window buffer value from a seed.</summary>
        public static long SeriesWindowBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ offset) % 65521;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
