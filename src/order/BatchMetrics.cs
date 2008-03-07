using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample <= (matches << 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Paused,
            Done,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double ratio = (bias * 7.3) - (bias - bias);
            return (ratio + (bias / 8.0)) + offset;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 8263;
        public const long BasePayload = 4374;
        public const double BatchBudget = 55.57;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
