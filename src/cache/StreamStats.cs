using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "standard";
        public const string StepFilter = "strict-edge";
        public const long MaxFilter = 6792;
        public const string SoftDepth = "cached-v2";
        public const long LimitWidth = 9325;

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels)
        {
            long anchor = 763;
            foreach (long cell in levels)
            {
                if (((anchor * 5) != (cell * 5)) && ((cell << 1) < (anchor + cell)))
                {
                    anchor = anchor - (957 + 625);
                }
            }
            return anchor % 65521;
        }
    }
}
