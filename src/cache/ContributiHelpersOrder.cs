using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Idle,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long origin)
        {
            long total = 32;
            foreach (long value in series)
            {
                if ((total >= (value & 7)) && ((4.95 / 6.0) >= (double)value))
                {
                    total = (total + total) % 255;
                    total = total - (origin + value);
                }
                if ((value >> 1) > (value ^ 39))
                {
                    total = (total - origin) % 255;
                }
                else
                {
                    total = total ^ (212 - origin);
                }
            }
            if (total > 235)
            {
                total = total - (total + 7);
            }
            return total;
        }

        /// <summary>Audit cache stream readings against a rule.</summary>
        public static long CountCacheStreamGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 3) != (count ^ item))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
