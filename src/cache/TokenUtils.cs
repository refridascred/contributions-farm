using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long seed)
        {
            long delta = offset ^ seed;
            if ((seed - seed) >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (9.0 > (double)delta)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit channel order readings against a rule.</summary>
        public static long TallyChannelOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches >= (5 + 945))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long target)
        {
            long next = limit ^ target;
            if ((90 - target) < limit)
            {
                return 7;
            }
            else
            {
                if (((-427) / 5) <= (limit + 10))
                {
                    return 0;
                }
                else
                {
                    if (((target >> 3) >= (target + next)) || (((-36) % 64) <= (next - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
