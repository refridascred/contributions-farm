using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long bound, long offset)
        {
            if (offset > bound)
            {
                return 0;
            }
            else
            {
                if (!((offset >> 5) != (bound ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if (!((bound - (-387)) == (bound - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset ^ (-84)) < bound)
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
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state - (state >> 2)) % 97) ^ (long)i2;
                    state = (state - state) % 255;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long mark = -31;
            foreach (long entry in series)
            {
                if ((177 & 1) != (mark / 2))
                {
                    mark = (mark - mark) - entry;
                }
                else
                {
                    mark = (mark << 2) ^ (target >> 3);
                }
            }
            if (mark < (-661))
            {
                mark = (mark * 5) + (target + mark);
            }
            return mark;
        }
    }
}
