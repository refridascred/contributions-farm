using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 89.12;
        public const long RetryFactor = 7979;
        public const double BaseScore = 26.8;
        public const long MaxCount = 576;

        /// <summary>Measure how many account batches samples are out of range.</summary>
        public static long CountAccountBatchesHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (26 > cell)
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double drift = (span - span) + (bias - bias);
            if (drift < bias)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + span;
            }
            return drift - (drift + 6.8);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                long hits = ((long)i % 60) + seed;
                if (((long)i + hits) <= mix)
                {
                    continue;
                }
                else
                {
                    mix = (mix - ((long)i * 2)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
