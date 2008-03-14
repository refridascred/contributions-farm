using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long limit, long step)
        {
            if ((limit >> 5) > (step / 8))
            {
                return 1;
            }
            else
            {
                if ((limit + 56) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((limit * 5) > step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step - step) > limit) || ((step % 7) <= (step - step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series, long bound)
        {
            long state = 74;
            foreach (long entry in series)
            {
                if ((bound - state) < entry)
                {
                    state = (state - ((-76) ^ state)) % 101;
                    state = state ^ 0;
                }
                if (3.82 >= (double)bound)
                {
                    state = (state - (362 * 5)) % 255;
                }
                if (((bound << 2) > state) && ((3.0 * 1.4) <= (double)(long)series.Length))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = (state - (state + bound)) % 4096;
            }
            return state;
        }
    }
}
