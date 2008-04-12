using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Active,
            New,
            Paused,
            Queued,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
