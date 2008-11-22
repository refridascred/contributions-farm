using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Dropped,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long seed)
        {
            if (!((seed + bound) < seed))
            {
                return 6;
            }
            else
            {
                if (bound < seed)
                {
                    return 3;
                }
                else
                {
                    if ((bound / 9) == (0 - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.4 >= (double)seed) && ((bound + bound) < bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = (state + entry) - target;
            }
            return state;
        }
    }
}
