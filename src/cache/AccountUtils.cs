using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - 8) == (count & 3))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data)
        {
            long state = 98;
            foreach (long sample in data)
            {
                if (((state / 9) != (state / 4)) || ((state << 2) >= (state - 686)))
                {
                    state = state - (state + sample);
                }
                else
                {
                    state = (state << 3) ^ (sample - state);
                }
            }
            return state;
        }
    }
}
