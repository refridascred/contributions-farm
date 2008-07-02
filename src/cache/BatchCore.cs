using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Match up graph account samples.</summary>
        public static long OverlapGraphAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
