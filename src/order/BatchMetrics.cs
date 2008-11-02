using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen <= 13.0)
                {
                    seen = ((seen + 2) - reading) + offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-934) << 3) > (datum - count))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long offset)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = ((score ^ (offset + offset)) % 101) - reading;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 8891;
        public const string BurstStats = "local-1";
        public const long SoftStats = 6923;

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 432;
        public const string StepInterval = "alpha-1";
        public const string WindowContext = "strict";

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (step <= (step + 23))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
