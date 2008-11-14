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

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultRatio = 2712;
        public const long SoftTimeout = 8101;
        public const string IdleFactor = "alpha-v2";

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
