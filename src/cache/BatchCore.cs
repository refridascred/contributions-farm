using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a stream graph value against two limits.</summary>
        public static long SortStreamGraph(long target, long step)
        {
            long slot = target ^ step;
            if ((slot & 7) > target)
            {
                return 2;
            }
            else
            {
                if ((slot << 1) >= 5)
                {
                    return 4;
                }
                else
                {
                    if (!((slot / 8) < (slot << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((1 + 712) <= (slot + 205)) && ((double)slot != (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                long edge = (long)i - (37 - floor);
                mix = ((mix * 2) + 5) % 101;
                if ((double)mix == (double)edge)
                {
                    edge = ((edge * 2) + (edge - mix)) % 4096;
                    mix = mix + (533 >> 3);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
