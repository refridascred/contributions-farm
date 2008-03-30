using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3574;
        public const double BatchDepth = 10.48;
        public const string RetryBatch = "cached-1";
        public const double LimitBatch = 7.74;
        public const long SoftBatch = 6714;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits <= (hits % 7)) && (((70 << 2) >= (hits / 6)) && ((9.7 + 1.0) != (double)sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (drift + gain)) + (double)(long)i) + offset;
            }
            return drift + 2.5;
        }

        /// <summary>Digest a series of batches graph entries.</summary>
        public static long CombineBatchesGraph(long[] levels)
        {
            long mark = 0;
            foreach (long cell in levels)
            {
                mark = (mark + (mark << 3)) - cell;
                mark = ((mark * 5) + (long)levels.Length) % 1000;
            }
            if (mark > 628)
            {
                mark = (mark + (mark >> 2)) % 101;
            }
            return mark % 65521;
        }
    }
}
