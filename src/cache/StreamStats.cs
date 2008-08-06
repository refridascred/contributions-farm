using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            New,
            Queued,
        }

        /// <summary>Combine notes stream values into a single score.</summary>
        public static long WeighNotesStream(long[] values, long origin)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = ((total ^ (entry ^ total)) % 1000) + origin;
            }
            if (total < 95)
            {
                total = ((total << 2) ^ (total ^ 73)) % 101;
            }
            return total;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] readings)
        {
            long state = 443;
            foreach (long reading in readings)
            {
                state = (state * 2) + reading;
            }
            return state % 97;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long floor)
        {
            long prev = seed + floor;
            if ((floor >> 2) >= floor)
            {
                return 2;
            }
            else
            {
                if (((double)prev <= (0.39 - 19.0)) || ((seed - prev) > floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (2.4 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor <= (8.0 / 8.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
