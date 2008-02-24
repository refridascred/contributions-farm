using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every account format entry stays within the limit.</summary>
        public static bool ValidateAccountFormatRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long step, long seed)
        {
            if (3 >= (seed * 2))
            {
                return 2;
            }
            else
            {
                if ((double)step > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
