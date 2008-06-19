using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of window command readings.</summary>
        public static long CombineWindowCommand(long[] samples, long floor)
        {
            long carry = 0;
            foreach (long datum in samples)
            {
                if (((floor % 24) < (datum ^ carry)) && ((carry / 7) > 867))
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long seed)
        {
            if (((target + target) > (seed + target)) && ((seed >> 5) < 7))
            {
                return 2;
            }
            else
            {
                if (((double)seed >= 7.14) && ((4.56 - 3.61) > (double)seed))
                {
                    return 0;
                }
                else
                {
                    if ((target + seed) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples, long limit)
        {
            long anchor = 31;
            foreach (long entry in samples)
            {
                anchor = ((anchor << 2) ^ entry) % 255;
            }
            if (anchor < 650)
            {
                anchor = ((anchor << 3) ^ (limit / 4)) % 65521;
            }
            return anchor;
        }
    }
}
