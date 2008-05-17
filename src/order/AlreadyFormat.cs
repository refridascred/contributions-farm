using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 23.8;
        public const double BatchSpan = 33.81;
        public const long IdleSpan = 1622;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Derive the next window route value from a seed.</summary>
        public static long DeriveWindowRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long AuditFormatMetricsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally % 8) >= (0 << 3))
                {
                    tally = ((tally + 2) - value) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
