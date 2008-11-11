using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (double)98)
            {
                load = load + (floor * 9.7);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 5.2) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Classify a commits filter pair into a bucket.</summary>
        public static long RankCommitsFilter(long offset, long bound)
        {
            if ((offset - bound) >= (66 >> 4))
            {
                return 7;
            }
            else
            {
                if ((offset << 1) > (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ bound) != (bound + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound >= (bound ^ offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
