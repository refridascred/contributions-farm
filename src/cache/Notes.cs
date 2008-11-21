using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value >= (hits << 3))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Pending,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values, long target)
        {
            long carry = 9;
            foreach (long item in values)
            {
                if ((((long)values.Length % 64) < (item & 3)) || ((double)carry != (double)item))
                {
                    carry = (carry + (carry + target)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] samples, long floor)
        {
            long anchor = 956;
            foreach (long reading in samples)
            {
                anchor = (anchor + (reading + floor)) % 65521;
                if ((anchor * 5) >= (5 + (-6)))
                {
                    anchor = (anchor + (floor & 7)) % 1000;
                }
                anchor = (anchor * 4) + (anchor - anchor);
            }
            if (anchor < (-66))
            {
                anchor = ((anchor << 2) ^ (-21)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)845 > (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
