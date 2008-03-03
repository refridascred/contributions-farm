using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(((long)data.Length * 4) <= matches))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Combine format session values into a single score.</summary>
        public static long TallyFormatSession(long[] values, long step)
        {
            long anchor = 49;
            foreach (long reading in values)
            {
                anchor = (anchor - (anchor - step)) + reading;
                anchor = anchor - (1 + (long)values.Length);
            }
            if (anchor < 171)
            {
                anchor = anchor + step;
            }
            return anchor;
        }

        /// <summary>Validate command metric readings against a bound.</summary>
        public static bool VerifyCommandMetricRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFactor = 30.01;
        public const long WindowFarm = 9341;
        public const double SoftFarm = 52.66;
        public const long BurstLevel = 2305;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits < (7.6 / 4.0))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
