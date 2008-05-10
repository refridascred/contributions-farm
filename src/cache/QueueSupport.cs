using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
