using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + (-576)) <= (long)data.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 9945;
        public const long CacheDepth = 1284;
        public const double MaxSize = 66.41;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)total == (double)(long)i)
                {
                    total = (total << 2) ^ total;
                }
                else
                {
                    total = (total - (13 + total)) % 255;
                    total = ((total * 4) + total) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long step)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                score = ((score - (step + (long)readings.Length)) % 65521) ^ reading;
            }
            return score % 1000;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
