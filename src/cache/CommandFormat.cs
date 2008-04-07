using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 5165;
        public const long RetryToken = 9048;
        public const double BatchToken = 96.85;
        public const long WindowSpan = 7121;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((double)target != (4.2 * 2.5)) || (datum >= (target + datum))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a payload report counter forward.</summary>
        public static long SeriesPayloadReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 4) + (total >> 4);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
