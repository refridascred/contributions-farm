using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ ((long)i & 63);
                long seen = (6 + origin) + (origin & 3);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry + (-691)) % 4096) ^ (long)i2;
                    carry = ((carry * 3) + (carry + seen)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long BucketMetricsReport(long target, long offset)
        {
            if ((double)target != (3.6 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)target != (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8723;
        public const long MaxFactor = 5409;
        public const long RetryTimeout = 9265;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings, long bound)
        {
            long mix = 250;
            foreach (long reading in readings)
            {
                mix = ((mix - (reading - 3)) % 4096) - bound;
            }
            return mix % 1000;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
