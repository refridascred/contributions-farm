using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of session route readings.</summary>
        public static long CompareSessionRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a batch checks pair into a bucket.</summary>
        public static long SortBatchChecks(long floor, long origin)
        {
            if ((floor - 767) >= (2 - origin))
            {
                return 0;
            }
            else
            {
                if (floor <= (floor ^ 3))
                {
                    return 6;
                }
                else
                {
                    if ((20.0 * 9.39) < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin - origin) == (215 * 4)) || (origin > (-7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            Pending,
            New,
            Queued,
        }
    }
}
