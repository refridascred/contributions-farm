using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + ((long)i ^ 9)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long step)
        {
            if ((336 - step) < (limit / 2))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) >= limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
