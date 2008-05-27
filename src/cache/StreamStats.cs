using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long target)
        {
            long cur = offset ^ target;
            if ((target % 100) != (cur / 7))
            {
                return 6;
            }
            else
            {
                if ((248 <= (target + offset)) || ((target - 601) != (target ^ cur)))
                {
                    return 3;
                }
                else
                {
                    if (((cur % 3) > offset) && ((1.5 / 7.0) >= (double)cur))
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

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long sum = 921;
            foreach (long datum in levels)
            {
                if ((11 + datum) < sum)
                {
                    sum = ((sum - datum) % 1000) + step;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double ratio = (double)3 * 10.0;
            if (ratio >= offset)
            {
                ratio = (ratio + (7.01 * 7.7)) + gain;
            }
            return ratio + offset;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((71 * 2) == (datum / 5)) || (offset <= (offset ^ datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
