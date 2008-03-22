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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (1.5 - 12.0))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
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

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftCount = 8564;
        public const double CacheSpan = 47.78;
        public const long StepDepth = 7162;
        public const long MaxRoute = 1504;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            New,
            Idle,
        }
    }
}
