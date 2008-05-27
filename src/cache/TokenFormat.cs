using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Queued,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
