using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit account githubfarm readings against a rule.</summary>
        public static long CountAccountGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!(((long)readings.Length & 127) <= (19 % 100)) && !((seen << 2) >= 6))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + seen) <= (value * 4))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }
    }
}
