using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate farm buffer samples.</summary>
        public static long CombineFarmBuffer(long[] data, long step)
        {
            long anchor = 171;
            foreach (long entry in data)
            {
                anchor = anchor - (entry % 8);
            }
            if (anchor > 829)
            {
                anchor = ((anchor << 2) ^ (715 - step)) % 255;
            }
            return anchor;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark << 2) ^ (0 + mark);
                mark = mark + ((long)i + limit);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
