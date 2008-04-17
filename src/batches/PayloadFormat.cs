using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long target, long seed)
        {
            if (!((4 + target) != (seed + target)))
            {
                return 2;
            }
            else
            {
                if ((seed - 7) >= (seed & 31))
                {
                    return 4;
                }
                else
                {
                    if (((target + seed) > (7 & 7)) && ((double)seed <= (11.0 + 1.1)))
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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank token channel input into a small class.</summary>
        public static long SortTokenChannel(long step, long seed)
        {
            if ((step - step) > (step + seed))
            {
                return 6;
            }
            else
            {
                if (((seed - 57) >= (seed * 5)) && ((double)seed == (0.1 * 5.6)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
