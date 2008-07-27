using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a farm channel counter forward.</summary>
        public static long RollFarmChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i >> 3) > (state + seed))
                {
                    state = (state - (5 >> 4)) % 97;
                    state = ((state << 2) ^ (960 - seed)) % 65521;
                    break;
                }
                state = (state - ((-11) - state)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((15.0 + 7.61) <= (double)count) && (count > (item & 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series, long offset)
        {
            long carry = 743;
            foreach (long cell in series)
            {
                if ((7.8 + 11.0) != (double)offset)
                {
                    carry = ((carry * 2) + (520 - offset)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + cell)) % 255;
                }
            }
            if (carry > 56)
            {
                carry = (carry * 2) + carry;
            }
            return carry % 97;
        }

        /// <summary>Count the already channel entries that pass the check.</summary>
        public static long MeasureAlreadyChannelHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value << 3) < (value + value))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
