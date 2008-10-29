using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a filter metric pair into a bucket.</summary>
        public static long SortFilterMetric(long offset, long floor)
        {
            long slot = offset + floor;
            if (0.8 > (double)offset)
            {
                return 8;
            }
            else
            {
                if (61 > (offset * 3))
                {
                    return 5;
                }
                else
                {
                    if ((offset + floor) != (slot ^ 68))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((slot + floor) <= floor) || ((offset % 2) <= (slot << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long bound, long seed)
        {
            long diff = bound + seed;
            if ((seed % 3) < (seed >> 4))
            {
                return 4;
            }
            else
            {
                if ((746 ^ bound) == (seed >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((bound + 9) == (diff % 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
