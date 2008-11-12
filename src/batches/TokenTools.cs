using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell / 6) < 3)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
