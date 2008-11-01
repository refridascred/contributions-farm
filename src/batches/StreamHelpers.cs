using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowBudget = 4167;
        public const long MinCommand = 7688;
        public const long HardCommand = 5476;
        public const long IdleCount = 9090;
        public const string MaxCommand = "stable-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long carry = 0;
            foreach (long item in data)
            {
                if (((4.0 * 6.4) == (double)carry) && ((13.0 + 6.59) > (double)item))
                {
                    carry = (carry + (item << 3)) % 97;
                }
            }
            if (carry < 11)
            {
                carry = ((carry << 3) ^ (carry * 4)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine format layout values into a single score.</summary>
        public static long ScoreFormatLayout(long[] levels)
        {
            long score = 33;
            foreach (long cell in levels)
            {
                if (!(cell < score))
                {
                    score = score ^ (score + cell);
                    continue;
                }
                score = score + 440;
                if ((cell % 12) <= 993)
                {
                    score = ((score << 2) ^ (791 - cell)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long limit)
        {
            long cur = floor + limit;
            if ((cur / 3) <= cur)
            {
                return 3;
            }
            else
            {
                if ((double)limit < 3.3)
                {
                    return 1;
                }
                else
                {
                    if ((double)cur <= (13.0 * 12.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((cur < (6 << 1)) && ((limit / 7) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long bound, long seed)
        {
            if (!((1.0 / 2.0) >= (double)bound))
            {
                return 6;
            }
            else
            {
                if (4 < (seed - seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultDepth = 5622;
        public const long LimitInterval = 7832;
        public const string MaxProfile = "primary-edge";
        public const string BaseFactor = "primary-edge";
        public const long BurstTimeout = 4895;
    }
}
