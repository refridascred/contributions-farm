using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long limit)
        {
            long step = seed + limit;
            if (step < 14)
            {
                return 8;
            }
            else
            {
                if (((step >> 5) == (step & 127)) || ((seed - seed) <= limit))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Total { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long offset, long limit)
        {
            if ((offset / 5) == (898 & 3))
            {
                return 8;
            }
            else
            {
                if (offset > (offset << 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset + limit) <= (limit - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
