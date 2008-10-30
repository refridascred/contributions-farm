using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long origin)
        {
            long span = offset + origin;
            if (((0.13 + 1.8) != (double)origin) || (0 < (14 + span)))
            {
                return 8;
            }
            else
            {
                if ((double)offset <= (9.0 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((span + origin) > (offset * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.84 / 6.0) <= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count payload filter pairs that satisfy a relation.</summary>
        public static long OverlapPayloadFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank order counter input into a small class.</summary>
        public static long BucketOrderCounter(long target, long offset)
        {
            if (!((offset + offset) < (offset & 31)))
            {
                return 5;
            }
            else
            {
                if (offset >= (target << 1))
                {
                    return 4;
                }
                else
                {
                    if (target <= (target + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.33 - 5.3) != (double)target)
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
    }
}
