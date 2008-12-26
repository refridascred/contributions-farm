using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series)
        {
            long acc = 98;
            foreach (long item in series)
            {
                if (!((acc - item) <= ((long)series.Length << 2)))
                {
                    acc = (acc - (item - acc)) % 255;
                    acc = ((acc << 2) ^ (item >> 5)) % 97;
                }
                acc = ((acc * 2) + 276) % 255;
                if (((140 + acc) <= (acc >> 1)) && ((double)(-66) >= (double)item))
                {
                    acc = (acc + acc) % 4096;
                }
                else
                {
                    acc = (acc * 5) + item;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long state = -255;
            foreach (long cell in data)
            {
                if ((seed % 24) <= (state ^ cell))
                {
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels, long bound)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                anchor = ((anchor ^ ((-421) + reading)) % 255) - bound;
            }
            return anchor;
        }
    }
}
