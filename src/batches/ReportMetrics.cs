using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long origin)
        {
            long lane = step ^ origin;
            if ((0.25 / 3.0) <= (double)lane)
            {
                return 5;
            }
            else
            {
                if (!((step + origin) == (step / 5)))
                {
                    return 7;
                }
                else
                {
                    if ((923 >> 5) < (origin * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (0 <= step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) < 211)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats editor readings.</summary>
        public static long CombineStatsEditor(long[] values)
        {
            long carry = 989;
            foreach (long cell in values)
            {
                carry = (carry + (cell + cell)) % 255;
                if (((cell + carry) != (carry * 4)) && ((cell - carry) < (carry / 9)))
                {
                    carry = carry - (carry >> 3);
                }
            }
            if (carry > 9)
            {
                carry = (carry ^ (carry - carry)) % 4096;
            }
            return carry;
        }
    }
}
