using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Match up batch contributi samples.</summary>
        public static long PairBatchContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
