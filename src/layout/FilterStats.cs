using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                sum = (sum + (cell ^ sum)) % 255;
            }
            if (sum < 428)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long target)
        {
            long bound = step + target;
            if ((bound ^ step) != (bound + target))
            {
                return 4;
            }
            else
            {
                if (!(step > bound))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 2) >= (bound + step))
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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long TallyFilterProfileGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((-7) - seed) <= tally)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
