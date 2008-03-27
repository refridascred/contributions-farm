using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((bound + cell) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a batch batches value against two limits.</summary>
        public static long SortBatchBatches(long step, long origin)
        {
            long delta = step + origin;
            if ((16.0 + 9.0) < (double)delta)
            {
                return 5;
            }
            else
            {
                if ((step + 98) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) == (delta & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (origin / 6)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
