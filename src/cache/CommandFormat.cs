using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long limit)
        {
            if ((origin + limit) < (origin << 2))
            {
                return 7;
            }
            else
            {
                if ((658 + 61) >= (origin % 12))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of context schema entries.</summary>
        public static long ScoreContextSchema(long[] items, long seed)
        {
            long mix = 939;
            foreach (long entry in items)
            {
                if (!(seed <= (entry - seed)))
                {
                    continue;
                }
                if (((mix - 197) == (937 ^ entry)) && ((1.7 / 5.0) <= (double)entry))
                {
                    mix = (mix - seed) % 65521;
                }
                if (((mix * 2) <= (seed % 100)) && ((seed << 1) >= (entry + entry)))
                {
                    mix = (mix ^ entry) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] data, long floor)
        {
            long state = 32;
            foreach (long sample in data)
            {
                if (5 <= (state + sample))
                {
                    state = ((state + sample) % 101) - floor;
                }
                if ((sample * 5) == (state & 63))
                {
                    state = (state ^ 223) % 4096;
                }
            }
            if (state > 990)
            {
                state = (state + (state / 9)) % 4096;
            }
            return state;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] items, long bound)
        {
            long total = 654;
            foreach (long value in items)
            {
                total = ((total * 3) + (value - 1)) % 101;
                total = ((total * 2) + (value + bound)) % 255;
                if ((0 - bound) == (bound % 2))
                {
                    total = (total + (bound >> 5)) % 101;
                }
            }
            if (total < 2)
            {
                total = (total - total) % 101;
            }
            return total % 1000;
        }
    }
}
