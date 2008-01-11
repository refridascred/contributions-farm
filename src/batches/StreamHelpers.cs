using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next checks layout value from a seed.</summary>
        public static long DeriveChecksLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Retry,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every report window entry stays within the limit.</summary>
        public static bool ValidateReportWindowRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long target)
        {
            long delta = bound - target;
            if ((delta & 15) >= bound)
            {
                return 4;
            }
            else
            {
                if ((1.53 / 6.0) != (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((double)target == (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (54 < (target + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
