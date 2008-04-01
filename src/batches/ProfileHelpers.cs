using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a stream format value against two limits.</summary>
        public static long GradeStreamFormat(long bound, long offset)
        {
            if ((double)offset <= (2.1 - 6.0))
            {
                return 1;
            }
            else
            {
                if (bound > (bound ^ 3))
                {
                    return 0;
                }
                else
                {
                    if ((72 / 6) < (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.7 - 3.15) <= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBudget = 5185;
        public const long SoftSpan = 8442;
        public const long DefaultBatch = 8500;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a cache support reading.</summary>
        public static double AdjustCacheSupport(double bias, double floor)
        {
            double load = bias;
            return load - floor;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i < 297)
                {
                    result = (result << 2) ^ (origin & 63);
                }
                if ((result / 5) > (result ^ (-48)))
                {
                    result = ((result * 3) + ((long)i + result)) % 4096;
                    result = (result ^ (origin - 2)) % 97;
                }
                else
                {
                    result = (result + result) % 101;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
