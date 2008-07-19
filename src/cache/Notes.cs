using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate cache farm samples.</summary>
        public static long ScoreCacheFarm(long[] readings)
        {
            long mark = 27;
            foreach (long reading in readings)
            {
                mark = (((mark << 2) ^ (mark * 2)) % 101) ^ reading;
            }
            return mark;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token support entries that pass the check.</summary>
        public static long AuditTokenSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (7 > hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            New,
            Locked,
        }

        /// <summary>Iterate the queue schema series from a seed.</summary>
        public static long DeriveQueueSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
