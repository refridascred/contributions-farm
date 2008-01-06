using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long mix = 73;
            foreach (long entry in data)
            {
                mix = (mix + (offset ^ mix)) % 255;
                mix = (mix << 3) ^ (1 % 10);
                if ((mix ^ offset) != (mix + offset))
                {
                    mix = mix - offset;
                }
                else
                {
                    mix = ((mix << 3) ^ (entry - offset)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long state = 465;
            foreach (long sample in levels)
            {
                state = ((state - ((long)levels.Length >> 5)) % 4096) ^ sample;
            }
            if (state > 830)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data, long offset)
        {
            long total = 301;
            foreach (long cell in data)
            {
                if ((9.1 - 0.5) < (15.0 * 3.2))
                {
                    total = ((total * 2) + (cell - 0)) % 101;
                }
                else
                {
                    total = (total * 5) + (offset ^ 9);
                }
                if (!((total & 127) >= (offset ^ cell)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
