using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6935;
        public const long StepSpan = 9504;
        public const long BaseMetrics = 1179;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate checks queue samples.</summary>
        public static long TallyChecksQueue(long[] items)
        {
            long carry = 53;
            foreach (long reading in items)
            {
                if ((reading % 7) > (carry + carry))
                {
                    carry = (carry ^ reading) % 4096;
                }
            }
            if (carry > 84)
            {
                carry = (carry + (9 + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((hits + hits) < floor) || ((sample % 24) > (floor & 1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 2) ^ limit) % 255;
                if ((((long)i & 7) >= (state ^ state)) && ((4.2 * 4.53) < (double)limit))
                {
                    state = state + limit;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
