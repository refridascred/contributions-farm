using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 31) < (cell - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] samples)
        {
            long anchor = 745;
            foreach (long datum in samples)
            {
                if (1.0 >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (datum * 5)) % 101;
                }
                else
                {
                    anchor = (anchor * 4) + (datum + (-24));
                }
            }
            return anchor;
        }
    }
}
