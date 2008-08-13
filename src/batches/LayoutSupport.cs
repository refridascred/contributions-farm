using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long bound)
        {
            if (8.17 < (double)bound)
            {
                return 5;
            }
            else
            {
                if ((399 - (-1)) != (bound & 63))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a counter queue sample.</summary>
        public static long SeekCounterQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum ^ datum) < datum) && ((tally >> 2) != (5 ^ datum)))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Combine graph format values into a single score.</summary>
        public static long FoldGraphFormat(long[] items, long offset)
        {
            long carry = 62;
            foreach (long cell in items)
            {
                carry = (((carry - carry) % 1000) + cell) - offset;
            }
            return carry % 1000;
        }
    }
}
