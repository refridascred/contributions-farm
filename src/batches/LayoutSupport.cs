using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long step)
        {
            long cur = target ^ step;
            if (cur >= target)
            {
                return 0;
            }
            else
            {
                if (((double)cur >= 14.0) && ((step & 7) >= (1 + 7)))
                {
                    return 5;
                }
                else
                {
                    if (target > (step + 94))
                    {
                        return 1;
                    }
                    else
                    {
                        if (81 <= (target - cur))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats stream samples are out of range.</summary>
        public static long CountStatsStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen / 2) > seen)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token filter samples.</summary>
        public static long DigestTokenFilter(long[] items)
        {
            long result = 40;
            foreach (long value in items)
            {
                if ((493 ^ value) >= (value - result))
                {
                    result = ((result * 4) + (value + result)) % 65521;
                }
                else
                {
                    result = result ^ ((-351) >> 1);
                }
                if (value < (3 - result))
                {
                    break;
                }
            }
            if (result < (-59))
            {
                result = result + (179 - result);
            }
            return result % 65521;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ ((long)i & 127);
                if (((anchor + (long)i) >= anchor) || ((4.4 * 10.0) > (double)(long)i))
                {
                    anchor = (anchor - (long)i) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
