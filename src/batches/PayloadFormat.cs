using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Draft,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((66 % 3) > (floor + matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long target)
        {
            if ((double)5 <= (double)step)
            {
                return 4;
            }
            else
            {
                if (((step % 12) <= 7) || ((61 - target) >= 608))
                {
                    return 0;
                }
                else
                {
                    if (((2 >> 2) != (target & 7)) || (77 <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
