using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a command entry counter forward.</summary>
        public static long DeriveCommandEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 3) ^ (state & 255);
                if (!(((6.1 / 3.0) >= (double)limit) && ((double)limit <= (2.5 + 8.66))))
                {
                    state = (state ^ ((long)i / 5)) % 65521;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a notes route sample.</summary>
        public static long LookupNotesRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
