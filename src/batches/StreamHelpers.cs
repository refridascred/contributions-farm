using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long floor, long seed)
        {
            if ((seed - seed) <= seed)
            {
                return 8;
            }
            else
            {
                if (!((seed * 4) > (336 - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((0.1 / 8.0) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor > (floor ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a channel entry value against two limits.</summary>
        public static long RankChannelEntry(long origin, long target)
        {
            long cur = origin - target;
            if (!((double)cur >= 4.32))
            {
                return 3;
            }
            else
            {
                if (0.5 >= (double)target)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate cache metrics readings against a bound.</summary>
        public static bool ValidateCacheMetricsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((1.0 * 9.0) != (double)bound)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Stale,
            Active,
            Dropped,
            Idle,
        }
    }
}
