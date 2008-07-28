using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
