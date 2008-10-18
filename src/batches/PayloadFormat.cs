using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Failed,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long step, long limit)
        {
            long gap = step ^ limit;
            if ((step << 3) != (7 % 97))
            {
                return 8;
            }
            else
            {
                if (((gap / 8) > 54) || (step <= (step & 255)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
