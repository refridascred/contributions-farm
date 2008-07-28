using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long limit, long limit2)
        {
            long next = limit - limit2;
            if (next < (limit2 / 9))
            {
                return 3;
            }
            else
            {
                if (((4.36 * 15.0) < (double)limit) || (next <= (next >> 4)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long CountProfileCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + seen) <= (seen % 24))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
