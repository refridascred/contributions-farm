using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long origin, long step)
        {
            long cur = origin ^ step;
            if ((cur - 528) != (755 / 9))
            {
                return 2;
            }
            else
            {
                if (((0.9 / 3.0) > (double)origin) && (cur < (6 + cur)))
                {
                    return 7;
                }
                else
                {
                    if ((step > (step - cur)) || ((double)step >= (9.0 / 3.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long CombineRecordCommand(long[] series)
        {
            long mix = 943;
            foreach (long sample in series)
            {
                if ((double)sample > 5.92)
                {
                    mix = (mix - 9) % 255;
                }
                else
                {
                    mix = (mix ^ (mix >> 5)) % 255;
                }
            }
            if (mix > (-4))
            {
                mix = ((mix * 3) + (mix ^ mix)) % 101;
            }
            return mix;
        }
    }
}
