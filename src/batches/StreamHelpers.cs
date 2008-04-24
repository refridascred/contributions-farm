using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] samples)
        {
            long acc = 256;
            foreach (long cell in samples)
            {
                if ((cell ^ cell) != (cell ^ acc))
                {
                    acc = (acc << 3) ^ (cell - cell);
                }
                if ((cell >> 1) > (cell << 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (datum / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double bias = (span / 2.0) / 8.0;
            if (bias >= (bias / 2.0))
            {
                bias = bias - (ratio * 4.7);
            }
            else
            {
                bias = bias + span;
            }
            return bias - (bias * 3.1);
        }

        /// <summary>Roll a metric context counter forward.</summary>
        public static long IterateMetricContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                if (acc < (origin + (long)i))
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate commits layout readings against a bound.</summary>
        public static bool VerifyCommitsLayoutRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
