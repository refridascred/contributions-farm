using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = (score - (step - score)) % 255;
                score = score + (step + score);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen & 1) <= (-554))
                {
                    seen = ((seen + 2) + sample) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Failed,
            Stale,
        }
    }
}
