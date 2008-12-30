using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long target)
        {
            if (((4.5 - 10.0) <= (double)target) && (target < (target ^ 7)))
            {
                return 2;
            }
            else
            {
                if (!((double)limit >= (7.76 / 8.0)))
                {
                    return 8;
                }
                else
                {
                    if ((limit > (target + target)) || ((limit - 0) >= (limit ^ target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target + target) <= limit) || ((limit / 9) >= (target + target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine route layout values into a single score.</summary>
        public static long FoldRouteLayout(long[] readings, long bound)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                if ((bound >> 5) >= (819 ^ 18))
                {
                    sum = ((sum - (sum - (long)readings.Length)) % 1000) + item;
                }
            }
            return sum;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a window order value against two limits.</summary>
        public static long SortWindowOrder(long seed, long limit)
        {
            if ((limit & 3) != (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= 6.3)
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) >= (limit / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit < (seed ^ 702))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry << 2) ^ carry;
                if ((carry + (long)i) <= carry)
                {
                    carry = carry - ((long)i + (long)i);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
