using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many route batch samples are out of range.</summary>
        public static long AuditRouteBatchHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen >= (seen - 1))
                {
                    seen = ((seen + 3) + item) - step;
                }
            }
            return seen;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long ClassifyChecksCommits(long target, long target2)
        {
            long edge = target + target2;
            if (!((double)target < 3.4))
            {
                return 6;
            }
            else
            {
                if (target > 1)
                {
                    return 1;
                }
                else
                {
                    if ((target2 & 255) < (9 & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge & 1) >= ((-4) >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data)
        {
            long mix = -333;
            foreach (long value in data)
            {
                if (mix < (mix - mix))
                {
                    mix = (mix - (mix + mix)) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (757 - value)) % 97;
                }
            }
            if (mix < (-1))
            {
                mix = (mix - (69 + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Locate a metric route reading by value.</summary>
        public static long LocateMetricRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token context series from a seed.</summary>
        public static long SeriesTokenContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
