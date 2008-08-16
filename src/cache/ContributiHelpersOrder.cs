using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = state - (state << 2);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value ^ 0) > (matches + origin))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}
