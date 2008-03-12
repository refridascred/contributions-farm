using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long floor)
        {
            long cur = bound + floor;
            if ((bound ^ floor) > (cur & 15))
            {
                return 8;
            }
            else
            {
                if (bound < (bound * 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long step)
        {
            if ((limit > (step ^ limit)) && ((limit + step) <= (82 ^ limit)))
            {
                return 4;
            }
            else
            {
                if ((7.51 - 7.75) != (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((entry >> 1) < (tally - entry)) || ((tally ^ 65) >= 270)) || ((entry << 1) <= (bound + entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                acc = acc ^ (acc >> 1);
                if (acc > datum)
                {
                    acc = (acc + acc) % 1000;
                }
                else
                {
                    acc = (acc - (datum << 2)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = acc ^ 863;
            }
            return acc % 4096;
        }
    }
}
