using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples)
        {
            long mix = 50;
            foreach (long entry in samples)
            {
                if ((98 / 9) > (entry & 7))
                {
                    mix = mix - (mix / 6);
                }
                if (((double)mix == (5.0 / 3.0)) && ((double)mix < (7.2 / 7.0)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long bound)
        {
            long offset = limit + bound;
            if ((limit / 2) == (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((limit & 15) <= (offset - limit))
                {
                    return 3;
                }
                else
                {
                    if ((19.0 - 3.07) > (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit >> 2) <= offset) && ((3.8 * 5.15) < (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long step, long limit)
        {
            if (2.6 <= (double)limit)
            {
                return 0;
            }
            else
            {
                if (step < (limit / 6))
                {
                    return 3;
                }
                else
                {
                    if (((step * 3) < (limit / 9)) || ((limit + step) >= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - 29) <= limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
