using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((5.28 + 6.6) > (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((sum * 3) + (reading * 5)) - origin;
            }
            return sum % 4096;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] series)
        {
            long total = 69;
            foreach (long cell in series)
            {
                if ((cell + total) >= (cell << 2))
                {
                    total = ((total << 3) ^ (total >> 1)) % 1000;
                }
            }
            if (total > 98)
            {
                total = (total - (total >> 4)) % 101;
            }
            return total % 97;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
