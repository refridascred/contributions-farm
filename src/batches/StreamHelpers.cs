using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstWidth = 5864;
        public const string MaxTimeout = "alpha-edge";
        public const double BaseCluster = 80.6;
        public const long BaseRatio = 6574;
        public const double MinCluster = 90.8;

        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long AuditSchemaBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count > (reading >> 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool ValidateSchemaProfileLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long MeasureGraphContextGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((2.5 < (double)item) || ((item / 5) != (503 - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
