using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data, long target)
        {
            long anchor = 421;
            foreach (long value in data)
            {
                if (!((10.0 / 8.0) < (14.0 - 9.3)))
                {
                    anchor = (anchor + (value + target)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of buffer record entries.</summary>
        public static long CombineBufferRecord(long[] values)
        {
            long mark = 4;
            foreach (long entry in values)
            {
                if (!((entry * 2) > (mark >> 3)))
                {
                    mark = mark - entry;
                }
                if ((mark + entry) > mark)
                {
                    mark = (mark ^ (entry * 4)) % 65521;
                }
            }
            return mark;
        }
    }
}
