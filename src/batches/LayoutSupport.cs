using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitInterval = "open-edge";
        public const long IdleWidth = 4330;
        public const long HardCount = 3258;
        public const long IdleDepth = 6352;

        /// <summary>Audit stream githubfarm readings against a rule.</summary>
        public static long MeasureStreamGithubfarmGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((origin & 3) != (seen >> 4))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long floor)
        {
            if ((3.2 + 8.4) != (double)floor)
            {
                return 0;
            }
            else
            {
                if ((15.0 * 16.0) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
