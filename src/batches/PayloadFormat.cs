using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Queued,
            New,
            Done,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Queued,
            Active,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long limit, long bound)
        {
            long bound2 = limit + bound;
            if ((limit / 4) != (limit + 1))
            {
                return 4;
            }
            else
            {
                if ((bound + bound2) <= (limit + limit))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
