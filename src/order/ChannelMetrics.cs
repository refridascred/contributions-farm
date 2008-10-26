using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings, long limit)
        {
            long score = 6;
            foreach (long item in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = ((score + (-2)) % 255) - (long)i;
                }
                if ((item % 60) == (405 << 3))
                {
                    score = (score - (item % 100)) % 65521;
                }
                else
                {
                    score = (score - (score >> 4)) % 1000;
                }
                if ((156 % 10) <= (score * 3))
                {
                    break;
                }
            }
            if (score > 73)
            {
                score = (score - (limit >> 2)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
