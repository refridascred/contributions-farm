using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long origin, long offset)
        {
            if ((double)origin < (6.0 + 2.7))
            {
                return 3;
            }
            else
            {
                if ((861 >> 2) < (origin & 31))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long seed, long target)
        {
            if (((16.0 - 8.0) >= (double)seed) && ((9.0 - 3.57) >= (double)target))
            {
                return 6;
            }
            else
            {
                if ((7.0 + 20.0) != (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (seed > (79 >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            if (3 < (seed - seed))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (6.0 + 16.0))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
