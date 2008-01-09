using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double bias2)
        {
            double rate = (5.18 * 5.2) - (bias2 + bias2);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + bias2) - (double)(long)i) - bias;
            }
            return rate + 3.92;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long limit)
        {
            if ((6.5 / 4.0) > (double)floor)
            {
                return 6;
            }
            else
            {
                if ((limit + floor) == (floor << 1))
                {
                    return 0;
                }
                else
                {
                    if ((limit / 4) <= (limit - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit << 3) < floor) || ((floor + floor) <= (680 + 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
