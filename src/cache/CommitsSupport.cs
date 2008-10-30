using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 2317;
        public const long CacheReport = 7705;
        public const long MinReport = 7440;
        public const long IdleReport = 2761;
        public const double DefaultCount = 89.72;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total - total) % 97;
                if ((target ^ target) >= 502)
                {
                    total = ((total * 5) + total) % 101;
                }
                if (target >= ((long)i / 3))
                {
                    total = ((total << 3) ^ (total + target)) % 101;
                    total = (total * 2) + (total >> 3);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
