using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many metrics report samples are out of range.</summary>
        public static long TallyMetricsReportMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1.3 - 4.87) > (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (((double)origin != (9.4 / 2.0)) || (origin >= 921))
            {
                return 5;
            }
            else
            {
                if (!((4.82 + 9.16) == (double)lane))
                {
                    return 2;
                }
                else
                {
                    if (((offset + 505) < (-490)) && ((double)lane <= (1.0 / 7.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
