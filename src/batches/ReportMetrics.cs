using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long origin, long limit)
        {
            long diff = origin ^ limit;
            if (((double)diff > (double)69) || ((double)diff > 2.4))
            {
                return 8;
            }
            else
            {
                if (((1 >> 5) >= origin) || ((limit * 4) < limit))
                {
                    return 7;
                }
                else
                {
                    if (25 <= diff)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit) < (limit + diff))
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

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftWidth = "alpha";
        public const long CacheLayout = 6752;
        public const long BurstFactor = 7550;
    }
}
