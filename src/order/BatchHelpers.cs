using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long seed, long step)
        {
            if (seed > (seed + 6))
            {
                return 7;
            }
            else
            {
                if ((136 + 495) != (step / 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
