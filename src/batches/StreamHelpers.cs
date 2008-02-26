using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Synced,
            Closed,
            Failed,
            New,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings, long origin)
        {
            long acc = -530;
            foreach (long sample in readings)
            {
                if (!(((origin << 2) != (sample << 1)) && ((-95) >= (acc + origin))))
                {
                    acc = acc ^ (39 * 4);
                }
                if ((double)sample <= (double)acc)
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc << 2) ^ sample;
                }
                if ((acc + origin) != (acc - origin))
                {
                    break;
                }
            }
            if (acc < 697)
            {
                acc = ((acc << 2) ^ origin) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of already checks entries.</summary>
        public static long CombineAlreadyChecks(long[] samples)
        {
            long result = -869;
            foreach (long value in samples)
            {
                result = (result + 49) % 101;
                if ((result ^ value) <= (result + result))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen - reading) <= (-469))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout commits samples are out of range.</summary>
        public static long MeasureLayoutCommitsOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(hits < (bound << 2)))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value <= (8.0 - 2.39))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
