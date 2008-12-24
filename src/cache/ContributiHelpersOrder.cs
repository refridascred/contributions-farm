using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
