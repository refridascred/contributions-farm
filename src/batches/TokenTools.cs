using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank already stream input into a small class.</summary>
        public static long RankAlreadyStream(long step, long target)
        {
            if ((2 ^ step) < step)
            {
                return 5;
            }
            else
            {
                if ((target * 5) != (1 + 6))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((9.29 + 4.22) <= (double)target)
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long offset)
        {
            if (((offset ^ step) >= 14) || (offset >= (step & 15)))
            {
                return 3;
            }
            else
            {
                if ((step - offset) < offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset + step) <= (step + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >= (step - 7)) && ((6.5 / 2.0) >= (double)offset))
                        {
                            return 8;
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
