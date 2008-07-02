using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long MeasureChecksLayoutMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((4.0 - 7.0) < (double)value)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double scale = (bias2 * 20.0) * 2.2;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - bias2) - (double)(long)i) - bias;
            }
            return scale + (double)89;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Failed,
            Retry,
            Idle,
        }
    }
}
