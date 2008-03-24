using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long OverlapBatchBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a route schema counter forward.</summary>
        public static long SeriesRouteSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i & 1) < (seed << 3))
                {
                    mix = (mix + ((long)i * 4)) % 1000;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
