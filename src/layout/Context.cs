using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Digest a series of metric order entries.</summary>
        public static long ScoreMetricOrder(long[] levels)
        {
            long mix = 497;
            foreach (long datum in levels)
            {
                if ((datum - mix) >= (mix >> 1))
                {
                    mix = (mix * 4) + (datum % 16);
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of already counter readings.</summary>
        public static long PairAlreadyCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Synced,
            Ready,
            Stale,
            Queued,
        }
    }
}
