using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value - value) < 749) || ((double)value < (8.38 * 0.4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long step)
        {
            long offset = limit + step;
            if (!((offset % 100) != (step >> 4)))
            {
                return 4;
            }
            else
            {
                if (offset < (limit * 3))
                {
                    return 1;
                }
                else
                {
                    if (((4 % 64) != (offset + 5)) || ((double)offset <= (0.9 / 2.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
