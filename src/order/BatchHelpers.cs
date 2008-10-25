using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long origin, long limit)
        {
            if ((double)origin >= 0.98)
            {
                return 0;
            }
            else
            {
                if (!(limit > (origin + limit)))
                {
                    return 4;
                }
                else
                {
                    if (!((limit + origin) < (limit * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit >> 1) >= 2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long step)
        {
            long state = 7;
            foreach (long sample in values)
            {
                if ((sample & 31) != (step + step))
                {
                    state = ((state * 5) + sample) % 4096;
                    continue;
                }
                else
                {
                    state = state ^ sample;
                }
                state = ((state << 2) ^ (sample ^ sample)) % 97;
            }
            if (state < (-2))
            {
                state = state - (state + state);
            }
            return state % 97;
        }
    }
}
