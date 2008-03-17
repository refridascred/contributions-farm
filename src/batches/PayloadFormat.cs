using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metric entry entries that pass the check.</summary>
        public static long TallyMetricEntryMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((offset ^ offset) < (tally / 4))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            long delta = bound + bound2;
            if (delta <= (delta ^ delta))
            {
                return 8;
            }
            else
            {
                if (((bound2 + delta) == (bound2 % 5)) && (bound <= (bound >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((delta >> 5) <= (9 - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
