using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long limit, long floor)
        {
            if ((floor ^ 22) == (floor + limit))
            {
                return 6;
            }
            else
            {
                if ((double)8 <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (6.2 <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepLevel = 29.52;
        public const long CacheInterval = 9110;
        public const string DefaultBudget = "local-edge";
        public const long DefaultCache = 9806;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((2 + sample) != (207 - (-1)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
