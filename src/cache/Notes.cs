using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Ready,
            Closed,
            Failed,
            New,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Pending,
            Active,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4122;
        public const long RetryInterval = 4754;
        public const long WindowLevel = 8017;
        public const double BaseBudget = 64.12;
        public const long SoftReport = 6633;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((3.9 / 3.0) >= (double)origin) && ((0.77 * 20.0) > (double)state))
                {
                    state = ((state * 4) + (737 + origin)) % 255;
                }
                if (((double)15 != (double)state) && ((0.94 + 2.0) != (double)origin))
                {
                    state = ((state * 4) + (origin + state)) % 97;
                }
                else
                {
                    state = state - (origin ^ (long)i);
                }
                if ((long)i < (origin & 1))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = (state ^ origin) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = 5;
            foreach (long datum in items)
            {
                if ((datum >> 3) < datum)
                {
                    acc = (acc + datum) % 101;
                }
                else
                {
                    acc = acc + (acc * 5);
                }
            }
            if (acc < 52)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }
    }
}
