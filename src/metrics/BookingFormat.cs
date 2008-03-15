using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Pending,
            Active,
        }

        /// <summary>Combine checks schema values into a single score.</summary>
        public static long TotalChecksSchema(long[] samples)
        {
            long result = -5;
            foreach (long cell in samples)
            {
                result = result + ((-4) + result);
                result = (result << 3) ^ (cell + cell);
            }
            if (result < (-62))
            {
                result = ((result << 2) ^ (613 * 2)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long CountFormatGithubfarmHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((15.0 + 1.0) <= (double)item) || ((tally + 2) == (tally % 3)))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((-67) < (matches + matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + count) == (count << 2))
                {
                    count = ((count + 1) + value) - floor;
                }
            }
            return count;
        }
    }
}
