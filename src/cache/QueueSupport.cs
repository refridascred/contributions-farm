using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Size { get; set; }
            public double Limit { get; set; }
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
