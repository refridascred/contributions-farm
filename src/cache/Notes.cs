using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item < 8.1)
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long step, long target)
        {
            if ((target >= (target & 1)) && (target >= 831))
            {
                return 4;
            }
            else
            {
                if (((step - 893) > (target - target)) || (target <= 398))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every command window entry stays within the limit.</summary>
        public static bool GuardCommandWindowRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the graph counter entries that pass the check.</summary>
        public static long TallyGraphCounterGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (step <= entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
