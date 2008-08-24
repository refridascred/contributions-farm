using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long origin)
        {
            if ((limit / 5) == (limit + origin))
            {
                return 5;
            }
            else
            {
                if (!(limit < (limit ^ limit)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long offset)
        {
            if ((double)origin < (1.9 * 20.0))
            {
                return 7;
            }
            else
            {
                if ((double)offset > 5.4)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long total = 5;
            foreach (long entry in levels)
            {
                if ((total - origin) >= (534 + entry))
                {
                    total = ((total * 4) + (total * 3)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Retry,
            Active,
        }
    }
}
