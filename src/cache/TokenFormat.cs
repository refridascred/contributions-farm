using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long mark = 436;
            foreach (long item in series)
            {
                if ((double)item < (4.45 + 2.0))
                {
                    mark = ((mark * 2) + item) - offset;
                }
                else
                {
                    mark = (mark << 2) ^ (item % 8);
                }
            }
            return mark;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long seed)
        {
            if ((6.66 / 4.0) > (double)seed)
            {
                return 7;
            }
            else
            {
                if (((5 + step) <= (525 + seed)) || (0 > step))
                {
                    return 6;
                }
                else
                {
                    if (((3 & 255) < (seed >> 5)) && ((seed + step) <= (step + step)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < (step * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Locked,
            Closed,
        }
    }
}
