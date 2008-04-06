using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Closed,
            Stale,
            Idle,
            Synced,
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

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double weight, double bias)
        {
            double rate = (bias - 6.8) + (double)6;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (2.3 - rate)) + (double)(long)i) + weight;
            }
            return rate + 18.0;
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
