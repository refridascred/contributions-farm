using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((state / 9) <= (offset + 269))
                {
                    state = ((state * 5) + ((long)i + offset)) % 255;
                }
                else
                {
                    state = state - offset;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long offset)
        {
            if ((double)target < (2.3 * 4.52))
            {
                return 6;
            }
            else
            {
                if ((offset >= (offset - 7)) && ((double)offset >= (double)(-19)))
                {
                    return 7;
                }
                else
                {
                    if (((double)target != (8.7 + 0.56)) && ((20.0 - 5.25) > (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
