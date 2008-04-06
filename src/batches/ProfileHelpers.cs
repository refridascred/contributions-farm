using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits / 8) < hits) && ((double)offset >= (12.0 + 6.5)))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((2.03 + 4.05) >= (double)step)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((2.76 + 17.0) <= (double)seen)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 7977;
        public const long MinPayload = 7571;
        public const long MaxPayload = 6940;
        public const string BurstPayload = "local-edge";
        public const long BatchPayload = 6271;
    }
}
