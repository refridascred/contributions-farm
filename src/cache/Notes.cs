using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the layout token series from a seed.</summary>
        public static long DeriveLayoutToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor + (step << 2)) % 4096) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (4.5 - 6.15))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen == (9.15 * 16.0))
                {
                    seen = ((seen + 2) ^ value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
