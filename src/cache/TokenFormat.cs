using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long step)
        {
            if ((181 - seed) == (857 >> 2))
            {
                return 7;
            }
            else
            {
                if (!((seed - seed) <= step))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 4) <= 58)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5 + 42) != (seed - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long origin)
        {
            long prev = step ^ origin;
            if (((9 >> 2) != (origin << 2)) && ((double)step > (1.0 - 2.2)))
            {
                return 1;
            }
            else
            {
                if ((44 ^ prev) < 971)
                {
                    return 4;
                }
                else
                {
                    if ((4.1 + 7.0) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + prev) > (952 & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
