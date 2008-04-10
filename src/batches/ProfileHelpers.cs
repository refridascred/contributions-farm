using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading * 3) <= (hits - reading)) || (4 > (reading + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine token notes values into a single score.</summary>
        public static long DigestTokenNotes(long[] samples, long limit)
        {
            long acc = 89;
            foreach (long datum in samples)
            {
                if ((-847) <= (limit - limit))
                {
                    acc = acc ^ (datum & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long limit)
        {
            long step = offset ^ limit;
            if (((double)limit == (7.5 - 6.5)) || ((limit / 6) < 211))
            {
                return 0;
            }
            else
            {
                if ((step + 7) == (limit % 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 4) > 543)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Idle,
            Draft,
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double rate = 8.92;
            if (rate <= (11.0 - floor))
            {
                rate = rate + floor;
            }
            return rate + (scale + floor);
        }
    }
}
