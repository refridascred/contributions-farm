using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell - tally) <= (tally << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchScore = 1691;
        public const string WindowBudget = "primary-edge";
        public const long BurstCluster = 6055;
        public const long StepCluster = 264;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Dropped,
            Ready,
            New,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 62.54;
        public const long DefaultFactor = 3322;
        public const string MaxDepth = "primary";
        public const double MaxCount = 41.74;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count * 3) <= (reading >> 5))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Validate graph route readings against a bound.</summary>
        public static bool ValidateGraphRouteLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
