using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every notes commits entry stays within the limit.</summary>
        public static bool CheckNotesCommitsRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long offset)
        {
            if (offset > (offset % 3))
            {
                return 1;
            }
            else
            {
                if ((bound & 1) >= (bound % 16))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long offset)
        {
            long mark = 17;
            foreach (long value in samples)
            {
                if (((long)samples.Length / 7) > (mark << 2))
                {
                    mark = (mark ^ (offset - value)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            New,
            Synced,
            Ready,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples, long seed)
        {
            long state = 22;
            foreach (long cell in samples)
            {
                state = (((state * 2) + state) % 97) + cell;
            }
            if (state > 7)
            {
                state = ((state << 2) ^ (393 - seed)) % 101;
            }
            return state;
        }
    }
}
