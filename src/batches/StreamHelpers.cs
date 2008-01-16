using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 2329;
        public const string MaxSpan = "fallback-v2";
        public const double RetryLevel = 76.5;
        public const double CacheFactor = 76.06;
        public const double IdleWidth = 56.73;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally > (tally + tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the schema buffer entries that pass the check.</summary>
        public static long MeasureSchemaBufferGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 1) >= value)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((seed % 100) < 87)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
