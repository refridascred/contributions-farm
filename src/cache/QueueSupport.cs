using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate token route samples.</summary>
        public static long TallyTokenRoute(long[] items, long origin)
        {
            long mix = 446;
            foreach (long item in items)
            {
                if ((5.5 / 8.0) >= (double)item)
                {
                    mix = ((mix + (39 * 3)) % 97) + origin;
                }
                else
                {
                    mix = (mix ^ 287) % 65521;
                }
            }
            return mix % 65521;
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
