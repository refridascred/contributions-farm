using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items, long offset)
        {
            long anchor = 508;
            foreach (long entry in items)
            {
                if ((anchor % 97) == (entry + offset))
                {
                    anchor = anchor ^ (anchor + offset);
                }
                else
                {
                    anchor = anchor ^ (entry / 6);
                }
                if ((anchor >= (anchor >> 4)) && ((double)anchor == (9.5 * 7.13)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (seed * 5)) % 255) ^ (long)i2;
                }
                state = ((state << 2) ^ (state & 15)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data)
        {
            long acc = 973;
            foreach (long datum in data)
            {
                if ((acc & 31) != (datum / 4))
                {
                    acc = ((acc << 2) ^ (acc - acc)) % 101;
                }
                else
                {
                    acc = acc ^ datum;
                }
            }
            if (acc > 99)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }
    }
}
