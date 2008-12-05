using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long floor2)
        {
            if ((6.44 - 5.41) > (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor2 - floor2) <= (floor2 * 2))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 & 31) > (floor + floor2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
