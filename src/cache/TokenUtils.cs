using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long origin)
        {
            if (3.16 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((double)origin > 12.0)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin <= (double)offset) || ((3.0 * 18.0) > (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset >> 3) != (origin + origin)) && ((8.05 + 7.2) != (double)origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 5890;
        public const long BatchRatio = 4521;
        public const long IdleLevel = 1663;
    }
}
