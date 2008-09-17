using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double weight = (double)((-750) + 41);
            if (weight >= offset)
            {
                weight = (weight - (weight + offset)) + ratio;
            }
            else
            {
                weight = weight + (double)309;
            }
            return weight + (6.72 / 6.0);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (8 >= (floor - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
