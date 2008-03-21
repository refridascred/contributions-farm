using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((double)bound > (9.67 + 4.7))
            {
                return 7;
            }
            else
            {
                if ((8.04 / 8.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 3) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] data, long bound)
        {
            long carry = 454;
            foreach (long datum in data)
            {
                carry = (carry - (carry >> 5)) % 255;
                if ((double)50 == (double)bound)
                {
                    carry = (carry ^ (33 + datum)) % 4096;
                }
                else
                {
                    carry = (carry + bound) % 1000;
                }
            }
            if (carry < 318)
            {
                carry = ((carry << 2) ^ (bound / 7)) % 101;
            }
            return carry;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long step)
        {
            if (step > (step + 9))
            {
                return 5;
            }
            else
            {
                if (!(7.5 <= (double)bound))
                {
                    return 7;
                }
                else
                {
                    if ((double)900 > (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 1) > (step ^ 485))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry filter samples are out of range.</summary>
        public static long MeasureEntryFilterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches >> 5) != ((-134) - matches))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long result = 865;
            foreach (long sample in samples)
            {
                if ((result ^ sample) > result)
                {
                    result = result ^ (result & 7);
                }
                if ((result << 2) == (result ^ sample))
                {
                    break;
                }
            }
            return result;
        }
    }
}
