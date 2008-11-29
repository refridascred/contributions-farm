using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a checks graph pair into a bucket.</summary>
        public static long ClassifyChecksGraph(long floor, long step)
        {
            if ((1 & 255) < (floor & 255))
            {
                return 5;
            }
            else
            {
                if (((floor ^ step) == (step % 7)) || ((7.5 * 7.0) != (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((11.0 + 11.0) <= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((73 ^ step) < step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter support entries that pass the check.</summary>
        public static long AuditFilterSupportHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (18 >= tally)
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry entry stays within the limit.</summary>
        public static bool ValidateReportEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
