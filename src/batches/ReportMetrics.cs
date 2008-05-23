using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long offset)
        {
            if (floor <= offset)
            {
                return 3;
            }
            else
            {
                if (offset < (floor >> 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
