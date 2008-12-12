using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count editor account pairs that satisfy a relation.</summary>
        public static long OverlapEditorAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
