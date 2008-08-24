using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((3.3 - 5.7) >= (double)(long)i) || (((long)i - sum) > (floor + sum)))
                {
                    sum = sum ^ 820;
                }
                else
                {
                    sum = (sum ^ (floor ^ sum)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long seed, long origin)
        {
            long offset = seed ^ origin;
            if ((2.63 + 18.0) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((offset - 62) > origin)
                {
                    return 7;
                }
                else
                {
                    if ((515 > origin) || ((origin + seed) <= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((6.75 / 7.0) < (double)offset) || ((offset * 3) < (offset + origin)))
                        {
                            return 6;
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
