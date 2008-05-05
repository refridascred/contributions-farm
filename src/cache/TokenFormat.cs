using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset / 7) == (offset - count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Roll a editor stats counter forward.</summary>
        public static long SeriesEditorStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((double)offset < (5.8 * 19.0))
                {
                    acc = (acc * 4) + (offset + (long)i);
                }
                else
                {
                    acc = acc - ((long)i + 50);
                    acc = (acc ^ offset) % 1000;
                }
                if ((98 ^ acc) != (acc * 4))
                {
                    acc = (acc << 3) ^ (offset / 2);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of tools batches readings.</summary>
        public static long CombineToolsBatches(long[] data)
        {
            long state = 7;
            foreach (long item in data)
            {
                state = (state - state) % 4096;
                if (item < (item % 5))
                {
                    state = (state - (item * 5)) % 255;
                }
            }
            if (state < 160)
            {
                state = (state ^ state) % 101;
            }
            return state;
        }
    }
}
