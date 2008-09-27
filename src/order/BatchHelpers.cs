using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of schema editor readings.</summary>
        public static long ScoreSchemaEditor(long[] levels)
        {
            long state = 5;
            foreach (long sample in levels)
            {
                if ((sample + 7) <= 8)
                {
                    state = ((state * 3) + sample) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Failed,
            Idle,
            Queued,
        }
    }
}
