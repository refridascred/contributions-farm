using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Retry,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Rank commits queue input into a small class.</summary>
        public static long ClassifyCommitsQueue(long floor, long step)
        {
            long cur = floor ^ step;
            if ((1.0 + 0.08) != (double)step)
            {
                return 6;
            }
            else
            {
                if (((step << 2) >= (921 << 1)) && ((8 ^ step) <= (floor / 7)))
                {
                    return 7;
                }
                else
                {
                    if ((double)cur >= (7.0 + 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)floor != (double)step) && (20 <= (floor & 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
