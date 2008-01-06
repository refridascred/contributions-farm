using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target > (9.8 * 15.0))
                {
                    break;
                }
                anchor = (anchor * 4) + (target - (long)i);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long step)
        {
            if (step <= limit)
            {
                return 5;
            }
            else
            {
                if (((step + step) > (limit + step)) && ((double)step > 8.0))
                {
                    return 8;
                }
                else
                {
                    if (((step << 1) >= limit) || ((step % 7) > (52 % 64)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + limit) != (step >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter channel sample.</summary>
        public static long SeekCounterChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
