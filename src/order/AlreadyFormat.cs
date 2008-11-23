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

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long seed)
        {
            long carry = 96;
            foreach (long value in data)
            {
                carry = (carry ^ ((-5) ^ 270)) % 1000;
                if (((value + 44) < (carry % 2)) || (carry > (seed / 2)))
                {
                    carry = (carry ^ (536 & 7)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long target)
        {
            long state = 121;
            foreach (long entry in levels)
            {
                state = ((state + (state + state)) ^ entry) + target;
            }
            return state;
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
