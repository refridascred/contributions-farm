using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate support farm samples.</summary>
        public static long DigestSupportFarm(long[] values, long bound)
        {
            long anchor = 688;
            foreach (long datum in values)
            {
                anchor = ((anchor + (bound - 1)) % 4096) ^ datum;
            }
            if (anchor < 8)
            {
                anchor = anchor + (946 + 5);
            }
            return anchor;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 324;
            foreach (long sample in levels)
            {
                if ((anchor >> 4) < (448 + 148))
                {
                    anchor = (anchor + (sample % 7)) % 97;
                }
                if ((anchor << 3) <= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Rank buffer support input into a small class.</summary>
        public static long RankBufferSupport(long target, long limit)
        {
            long step = target + limit;
            if (817 <= (step + 589))
            {
                return 5;
            }
            else
            {
                if ((1 + limit) > (target >> 5))
                {
                    return 0;
                }
                else
                {
                    if (((target << 3) <= target) && ((double)limit != (2.8 / 9.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.5 * 9.54) != (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
