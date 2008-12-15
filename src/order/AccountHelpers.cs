using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data)
        {
            long acc = 685;
            foreach (long value in data)
            {
                if (!((8 + value) != (value + value)))
                {
                    acc = (acc + (value ^ value)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long GradeEntryMetric(long limit, long offset)
        {
            long offset2 = limit + offset;
            if ((offset2 + limit) <= (offset << 2))
            {
                return 4;
            }
            else
            {
                if ((double)44 == (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit != (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long offset, long origin)
        {
            long span = offset - origin;
            if ((span << 2) < offset)
            {
                return 2;
            }
            else
            {
                if (span > (span ^ origin))
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) != (offset - span))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.22 + 4.7) != (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
