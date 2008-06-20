using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long limit)
        {
            long span = seed + limit;
            if (((19.0 - 5.15) <= (double)span) || (2 <= limit))
            {
                return 6;
            }
            else
            {
                if ((limit + seed) > span)
                {
                    return 3;
                }
                else
                {
                    if ((seed - limit) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values, long limit)
        {
            long state = 2;
            foreach (long entry in values)
            {
                if ((entry >= (state >> 1)) || ((entry ^ limit) == (limit & 127)))
                {
                    state = (state ^ (state * 3)) % 101;
                }
            }
            return state;
        }
    }
}
