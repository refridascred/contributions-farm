using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry << 2) ^ (60 << 3)) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 3) >= count) || ((count << 3) >= ((-57) + 383)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Ready,
            Paused,
            Stale,
            Pending,
        }
    }
}
