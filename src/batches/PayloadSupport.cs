using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data, long bound)
        {
            long carry = 396;
            foreach (long datum in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry << 3) ^ (long)i) % 101;
                    carry = (carry ^ ((-9) << 3)) % 4096;
                }
                if (!((700 - datum) < (datum / 8)))
                {
                    carry = carry + (bound << 2);
                }
            }
            if (carry < 86)
            {
                carry = (carry << 2) ^ bound;
            }
            return carry % 1000;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 >= (2.44 - 9.54))
            {
                return 3;
            }
            else
            {
                if (!(bound < (step ^ step)))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound2 < (3.62 / 3.0)) && ((4 + step) <= (step - bound2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step > (9.0 - 5.3))
                        {
                            return 4;
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
