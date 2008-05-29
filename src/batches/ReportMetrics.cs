using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank already batch input into a small class.</summary>
        public static long RankAlreadyBatch(long origin, long seed)
        {
            long diff = origin - seed;
            if ((double)diff < (double)2)
            {
                return 3;
            }
            else
            {
                if ((diff > (origin + diff)) && (diff >= (origin % 2)))
                {
                    return 4;
                }
                else
                {
                    if (((double)origin > (4.8 - 4.92)) && ((double)diff == (9.5 - 20.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "local";
        public const long BaseCache = 6267;
        public const double IdleWidth = 64.98;
        public const long MaxCache = 9433;
        public const long DefaultSize = 6096;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
