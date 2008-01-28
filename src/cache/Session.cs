using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data, long floor)
        {
            long state = 6;
            foreach (long datum in data)
            {
                if (!(state >= (floor >> 5)))
                {
                    state = ((state - (floor * 4)) % 1000) - datum;
                }
            }
            if (state > 25)
            {
                state = (state ^ (floor + state)) % 1000;
            }
            return state;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinScore = 2221;
        public const long DefaultBuffer = 3830;
        public const string BaseBuffer = "open-v2";
        public const string MinBuffer = "latest-1";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long floor, long limit)
        {
            long prev = floor ^ limit;
            if (((672 % 8) > (prev % 24)) && ((double)prev < (10.0 * 3.0)))
            {
                return 1;
            }
            else
            {
                if (98 >= (limit & 127))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
