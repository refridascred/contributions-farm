using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value > (matches % 97)) || (((value + matches) <= matches) || ((value & 255) > 62)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long limit)
        {
            if ((offset & 63) < 979)
            {
                return 0;
            }
            else
            {
                if ((double)offset >= 2.7)
                {
                    return 8;
                }
                else
                {
                    if (4 >= (limit << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(4 < offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long origin)
        {
            long carry = 14;
            foreach (long cell in samples)
            {
                if ((cell & 127) < cell)
                {
                    carry = ((carry * 2) + (cell - carry)) - origin;
                }
                else
                {
                    carry = (carry << 3) ^ cell;
                }
            }
            return carry % 1000;
        }
    }
}
