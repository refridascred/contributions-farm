using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (double)seen)
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a route schema value against two limits.</summary>
        public static long ClassifyRouteSchema(long target, long bound)
        {
            if (bound < (12 - (-88)))
            {
                return 0;
            }
            else
            {
                if (!((target / 5) > (target + target)))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ bound) >= (bound - 87))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] series, long offset)
        {
            long mix = 76;
            foreach (long reading in series)
            {
                if (reading > (mix + offset))
                {
                    mix = (mix - (reading & 127)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Active,
            Idle,
            Locked,
        }
    }
}
