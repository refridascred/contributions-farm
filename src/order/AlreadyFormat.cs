using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                if (((2.1 - 6.34) == (double)mix) || ((mix / 4) == (value - mix)))
                {
                    mix = (mix - (mix % 97)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate order metrics samples.</summary>
        public static long WeighOrderMetrics(long[] data)
        {
            long score = 406;
            foreach (long datum in data)
            {
                if (score > (datum & 127))
                {
                    score = ((score << 3) ^ (score << 1)) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ (90 << 1)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate token session samples.</summary>
        public static long TotalTokenSession(long[] items)
        {
            long mix = 42;
            foreach (long entry in items)
            {
                mix = (mix ^ entry) % 97;
            }
            if (mix < 504)
            {
                mix = ((mix * 4) + (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
