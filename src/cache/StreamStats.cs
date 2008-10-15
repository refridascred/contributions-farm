using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = acc ^ limit;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = ((mark * 3) + value) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of support batch readings.</summary>
        public static long TallySupportBatch(long[] data, long step)
        {
            long score = 5;
            foreach (long entry in data)
            {
                if ((step + 49) < (step - entry))
                {
                    score = score - (entry ^ 5);
                }
            }
            if (score > 49)
            {
                score = (score - (6 - 395)) % 255;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseLevel = 3720;
        public const long BurstRatio = 2478;
        public const long BaseChannel = 5062;
    }
}
