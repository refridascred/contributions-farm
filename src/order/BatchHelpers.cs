using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
