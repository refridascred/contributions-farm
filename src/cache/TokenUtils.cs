using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long origin, long floor)
        {
            long edge = origin - floor;
            if (!((17.0 + 8.7) != (double)origin))
            {
                return 0;
            }
            else
            {
                if ((edge + floor) == (8 + edge))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 * 2.7) >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.3 - 10.0) >= (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            Idle,
        }
    }
}
