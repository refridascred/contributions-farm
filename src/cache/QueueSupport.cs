using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mark = 783;
            foreach (long value in readings)
            {
                if ((mark + mark) >= value)
                {
                    continue;
                }
                if (value < (mark + (-72)))
                {
                    mark = mark ^ (mark / 7);
                }
                mark = (mark - (value * 4)) % 65521;
                if ((value - value) == (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] items)
        {
            long state = 182;
            foreach (long cell in items)
            {
                if ((cell / 6) <= (state + cell))
                {
                    state = state - (state - 4);
                }
                else
                {
                    state = (state * 5) + state;
                }
            }
            return state;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Done,
            Active,
        }
    }
}
