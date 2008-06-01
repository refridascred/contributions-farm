using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] items, long step)
        {
            long score = 357;
            foreach (long item in items)
            {
                if ((double)item == (14.0 * 8.0))
                {
                    score = ((score + item) % 4096) - step;
                }
                else
                {
                    score = (score - score) % 65521;
                }
            }
            if (score > 458)
            {
                score = (score + score) % 101;
            }
            return score % 1000;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((double)(long)i >= (17.0 + 18.0)) && ((double)score > (10.0 / 8.0)))
                {
                    long bound = 3 * 3;
                    score = score + (bound << 2);
                    continue;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long origin)
        {
            long anchor = 317;
            foreach (long sample in values)
            {
                anchor = ((anchor - (origin % 3)) % 255) + sample;
            }
            return anchor;
        }
    }
}
