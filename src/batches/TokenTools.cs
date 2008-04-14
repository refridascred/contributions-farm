using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long acc = -55;
            foreach (long value in series)
            {
                acc = ((acc << 2) ^ (value ^ 63)) % 101;
                if (!((value - value) < (value + seed)))
                {
                    acc = (acc - 376) % 65521;
                }
                acc = acc + (acc - 42);
            }
            if (acc > 0)
            {
                acc = (acc - (seed + seed)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!(seen < (reading - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
