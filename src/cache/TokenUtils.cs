using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first report profile entry that matches the target.</summary>
        public static long LookupReportProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long step)
        {
            if (step >= (offset - step))
            {
                return 1;
            }
            else
            {
                if ((step < (offset / 5)) && ((double)step <= (3.3 + 2.4)))
                {
                    return 3;
                }
                else
                {
                    if (!((34 ^ offset) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset & 127) <= (step << 1)) && ((double)96 != (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long limit)
        {
            long next = step ^ limit;
            if ((limit / 4) >= (next - next))
            {
                return 1;
            }
            else
            {
                if ((limit % 97) > (49 - step))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
