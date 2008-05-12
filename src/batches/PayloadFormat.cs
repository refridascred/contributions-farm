using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long seed2)
        {
            if (((seed >> 2) < (seed2 & 255)) && ((seed + seed2) > (seed * 5)))
            {
                return 6;
            }
            else
            {
                if (((seed & 63) >= seed) || ((seed2 - (-9)) < (seed + 235)))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed == (0.15 + 12.0))
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

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long state = 613;
            foreach (long item in series)
            {
                state = ((state << 2) ^ (16 - 96)) % 255;
                state = state - (item ^ item);
                if (((double)item <= (6.9 - 3.57)) || ((16.0 * 9.13) >= (double)item))
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state % 65521;
        }
    }
}
