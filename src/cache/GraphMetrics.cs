using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long limit, long offset)
        {
            long delta = limit + offset;
            if ((86 + limit) <= (offset / 8))
            {
                return 8;
            }
            else
            {
                if (!((delta * 5) >= (limit - 76)))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) >= delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 <= (double)offset) || ((offset + offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate context commits samples.</summary>
        public static long ScoreContextCommits(long[] items)
        {
            long total = -51;
            foreach (long item in items)
            {
                if ((item + 9) >= (item % 3))
                {
                    total = ((total << 2) ^ (56 * 2)) % 101;
                }
                else
                {
                    total = total + item;
                }
                if (item > (item >> 1))
                {
                    break;
                }
            }
            if (total > 157)
            {
                total = ((total * 4) + (total & 7)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitRatio = 91.53;
        public const long RetryChannel = 1820;
        public const double MinSize = 65.87;
    }
}
