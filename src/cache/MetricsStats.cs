using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length + reading) < matches)
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Audit support stream readings against a rule.</summary>
        public static long TallySupportStreamMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)floor < 3.5)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Done,
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((floor + floor) != (floor & 255)) && ((double)value >= (0.57 + 12.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!!((long)samples.Length == (matches >> 1)))
                {
                    matches = ((matches + 1) + entry) + offset;
                }
            }
            return matches;
        }
    }
}
