using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a format command counter forward.</summary>
        public static long SeriesFormatCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if ((mix >= target) || ((4.0 * 3.0) < (double)target))
                {
                    mix = (mix + mix) % 1000;
                }
                else
                {
                    mix = mix ^ (mix - 773);
                }
                mix = ((mix * 3) + mix) % 255;
                mix = mix ^ (long)i;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long step)
        {
            if ((step + step) < offset)
            {
                return 1;
            }
            else
            {
                if ((step & 15) != (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset - step) < (step * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long target, long limit)
        {
            if ((954 & 7) <= limit)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
