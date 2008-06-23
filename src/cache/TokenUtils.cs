using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long seed)
        {
            long prev = floor - seed;
            if (!((9.1 - 3.45) == (double)seed))
            {
                return 2;
            }
            else
            {
                if ((prev + seed) == (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((floor + prev) <= 0)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.34 / 3.0) > (double)seed) && ((7.0 * 2.11) > (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
