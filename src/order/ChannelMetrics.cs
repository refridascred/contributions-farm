using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of tools support readings.</summary>
        public static long ScoreToolsSupport(long[] samples, long limit)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                state = ((state * 2) + (datum ^ state)) + limit;
            }
            if (state < 7)
            {
                state = ((state * 3) + (long)samples.Length) % 1000;
            }
            return state;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
