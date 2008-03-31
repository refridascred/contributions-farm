using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items, long offset)
        {
            long mix = 265;
            foreach (long entry in items)
            {
                if (!((entry & 255) > entry))
                {
                    mix = (mix << 2) ^ (entry ^ offset);
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long step, long offset)
        {
            long step2 = step - offset;
            if ((8.6 * 3.0) != (double)offset)
            {
                return 5;
            }
            else
            {
                if (step2 > offset)
                {
                    return 0;
                }
                else
                {
                    if ((step + offset) != (197 - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((5 + step2) <= step) && ((step2 + offset) >= 72))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Done,
            Queued,
            Retry,
        }
    }
}
