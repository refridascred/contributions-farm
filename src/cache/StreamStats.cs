using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of farm context readings.</summary>
        public static long OverlapFarmContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Ready,
            New,
            Paused,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-edge";
        public const long BaseEntry = 7377;
        public const long StepEntry = 613;
    }
}
