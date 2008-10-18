using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count > (5.0 * 0.6))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support tools entries.</summary>
        public static long TotalSupportTools(long[] samples, long offset)
        {
            long state = 122;
            foreach (long value in samples)
            {
                if ((value - value) >= state)
                {
                    state = ((state << 2) ^ (value % 7)) % 1000;
                    state = ((state << 2) ^ (state >> 3)) % 101;
                }
                state = (state - (state << 2)) % 255;
                state = ((state * 4) + (offset + offset)) % 97;
            }
            if (state > 50)
            {
                state = state - (state ^ 908);
            }
            return state % 97;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                long bound = (target >> 3) + ((long)i << 2);
                if ((mix / 7) < ((long)i + bound))
                {
                    bound = (bound - (bound << 3)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length > (count - 835))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
