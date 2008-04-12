using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long step2)
        {
            long next = step - step2;
            if (step2 >= (next & 15))
            {
                return 2;
            }
            else
            {
                if ((next + step2) > (step & 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)next < 5.51)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((-11) >= (step << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }
    }
}
