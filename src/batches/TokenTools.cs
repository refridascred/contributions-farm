using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long limit)
        {
            if ((bound + 1) >= bound)
            {
                return 8;
            }
            else
            {
                if ((bound + bound) < (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound * 5))
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

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)floor > 2.31)
                {
                    long gap = 42 + floor;
                    total = (total ^ (gap - floor)) % 1000;
                    break;
                }
                if ((double)floor < (10.0 * 1.7))
                {
                    total = ((total << 3) ^ ((long)i << 2)) % 97;
                }
                else
                {
                    total = total - (floor / 9);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
