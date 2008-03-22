using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)seen <= (4.17 * 19.0))
                {
                    seen = ((seen + 2) - sample) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            long span = origin - limit;
            if (((origin % 16) <= limit) || (1 >= origin))
            {
                return 2;
            }
            else
            {
                if ((limit >> 5) >= (origin ^ limit))
                {
                    return 7;
                }
                else
                {
                    if (((limit + origin) > (2 % 7)) && (span > (limit + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit + limit) < (span >> 3)) && (6 >= (limit - origin)))
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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (9.0 > (0.5 - 7.6))
                {
                    hits = ((hits + 1) + value) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            New,
            Idle,
        }
    }
}
