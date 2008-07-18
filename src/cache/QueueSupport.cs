using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long target)
        {
            long state = 16;
            foreach (long cell in values)
            {
                state = ((state * 2) + (target ^ cell)) % 1000;
            }
            if (state < (-432))
            {
                state = (state << 2) ^ (state - state);
            }
            return state % 4096;
        }

        /// <summary>Accumulate account session samples.</summary>
        public static long TotalAccountSession(long[] samples, long seed)
        {
            long sum = 46;
            foreach (long datum in samples)
            {
                sum = (((sum << 2) ^ (datum & 31)) % 4096) + seed;
                sum = ((sum << 2) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
