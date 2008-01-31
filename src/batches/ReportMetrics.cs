using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(3.0 > (double)cell))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the record profile series from a seed.</summary>
        public static long SeriesRecordProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry << 3) ^ (920 + seed);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry + (9 << 1)) % 65521) + (long)i2;
                    carry = (carry << 2) ^ carry;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
