using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long seed, long floor)
        {
            if (((16.0 + 2.0) > (double)floor) && ((seed ^ seed) != (seed << 3)))
            {
                return 4;
            }
            else
            {
                if ((double)floor > (7.0 + 9.8))
                {
                    return 5;
                }
                else
                {
                    if ((666 % 7) == (seed & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((61 - seed) <= (floor << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Synced,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
