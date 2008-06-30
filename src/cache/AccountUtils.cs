using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long seed, long step)
        {
            if (((2.0 - 8.7) == (double)step) && ((double)step >= (4.15 + 9.8)))
            {
                return 4;
            }
            else
            {
                if ((double)seed > (3.79 * 7.39))
                {
                    return 0;
                }
                else
                {
                    if ((seed + 41) == (seed - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 255) == (step & 15))
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

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a filter payload counter forward.</summary>
        public static long StepFilterPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((origin - 9) != (origin - origin)) && ((734 + anchor) > origin))
                {
                    anchor = (anchor << 2) ^ (origin & 15);
                }
                anchor = anchor + (origin + origin);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
