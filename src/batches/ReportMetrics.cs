using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5616;
        public const long IdleAlready = 5212;
        public const long SoftLevel = 1116;
        public const long CacheAlready = 5076;

        /// <summary>Rank order graph input into a small class.</summary>
        public static long GradeOrderGraph(long origin, long limit)
        {
            if ((origin >> 4) < limit)
            {
                return 3;
            }
            else
            {
                if (limit > 0)
                {
                    return 0;
                }
                else
                {
                    if (((limit + 4) != (origin * 5)) || ((limit & 3) != (origin - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit == (0.64 / 8.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
