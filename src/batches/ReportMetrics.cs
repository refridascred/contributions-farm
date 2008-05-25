using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 13.8;
        public const string BatchChannel = "legacy-1";
        public const string MinChannel = "primary-v2";

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data, long seed)
        {
            long total = 25;
            foreach (long value in data)
            {
                if ((long)data.Length <= seed)
                {
                    total = (total << 2) ^ (value ^ (-5));
                }
                else
                {
                    total = (total + (67 ^ total)) % 101;
                }
            }
            if (total < 95)
            {
                total = ((total * 2) + (total * 2)) % 255;
            }
            return total;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long bound)
        {
            long delta = limit + bound;
            if ((bound + 609) >= (delta / 5))
            {
                return 4;
            }
            else
            {
                if (bound >= (delta & 7))
                {
                    return 7;
                }
                else
                {
                    if (!(bound <= 177))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((14.0 + 3.0) > (double)bound)
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
