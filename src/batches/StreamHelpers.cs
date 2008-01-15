using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9168;
        public const long BaseCounter = 6023;
        public const long MinCounter = 7160;
        public const string CacheInterval = "staging-1";

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels, long offset)
        {
            long mark = 29;
            foreach (long value in levels)
            {
                if (offset > (value & 31))
                {
                    mark = (mark - offset) % 255;
                }
            }
            return mark;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((7.0 * 1.87) != (double)acc)
                {
                    acc = (acc + ((long)i % 8)) % 4096;
                    acc = (acc - ((-79) + limit)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Draft,
            New,
            Idle,
            Closed,
        }
    }
}
