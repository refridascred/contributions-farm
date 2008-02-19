using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits % 16) > reading) || ((hits - hits) != (hits / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] series)
        {
            long acc = 90;
            foreach (long cell in series)
            {
                long cur = cell & 1;
                if ((5.5 / 6.0) == (double)cur)
                {
                    cur = (cur - (cell + acc)) % 101;
                }
                if (cell < (cell << 3))
                {
                    acc = ((acc * 4) + (acc * 5)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits << 1) != (value ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
