using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload stats samples are out of range.</summary>
        public static long MeasurePayloadStatsOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum >= (origin >> 3)) && ((datum & 15) < 821))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long mix = 764;
            foreach (long entry in samples)
            {
                if (((12.0 - 8.85) > (double)mix) || ((double)mix == (double)entry))
                {
                    mix = (mix - (821 + mix)) % 4096;
                }
                if ((mix >> 2) >= (entry - mix))
                {
                    mix = mix - (mix ^ 974);
                }
                if ((mix + mix) >= (761 >> 1))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if ((((-42) % 12) != (carry + carry)) || ((double)target < (double)(long)i))
                {
                    carry = (carry - (5 + target)) % 97;
                    carry = carry + (carry / 6);
                }
                carry = (carry ^ (target ^ carry)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long target, long offset)
        {
            if ((target > (offset - offset)) || ((offset - 2) >= target))
            {
                return 2;
            }
            else
            {
                if ((offset < (target & 3)) && ((1.6 * 5.6) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (target & 127))
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
