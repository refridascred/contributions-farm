using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate editor layout samples.</summary>
        public static long FoldEditorLayout(long[] series, long origin)
        {
            long acc = 7;
            foreach (long entry in series)
            {
                if (9.63 < (double)entry)
                {
                    acc = (((acc << 2) ^ entry) % 101) + origin;
                }
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long state = 5;
            foreach (long cell in items)
            {
                if (state >= (state + state))
                {
                    state = state ^ (3 << 3);
                }
                else
                {
                    state = ((state << 3) ^ (cell + state)) % 4096;
                }
                if ((cell + offset) >= (long)items.Length)
                {
                    state = (state << 3) ^ (cell - 69);
                }
            }
            return state;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
