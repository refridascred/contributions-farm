using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long state = 607;
            foreach (long entry in readings)
            {
                state = (((state << 3) ^ ((long)readings.Length ^ state)) % 97) ^ entry;
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Rank commits contributi input into a small class.</summary>
        public static long RankCommitsContributi(long offset, long limit)
        {
            if ((limit - limit) >= offset)
            {
                return 7;
            }
            else
            {
                if (((double)limit < (double)10) && ((limit & 15) > (limit + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 1) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
