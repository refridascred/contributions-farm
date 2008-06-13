using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((2.35 / 6.0) < (double)sample)
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data, long offset)
        {
            long state = 24;
            foreach (long reading in data)
            {
                if ((((-38) - state) <= offset) || ((double)reading <= (7.94 * 1.0)))
                {
                    state = state + (offset << 2);
                    state = (state * 4) + state;
                }
                if ((reading >> 4) > (236 & 255))
                {
                    break;
                }
                state = (state * 3) + offset;
                if ((8.0 / 7.0) >= (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }
    }
}
