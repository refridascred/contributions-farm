using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double load = (weight / 3.0) * 0.7;
            return (load + load) + offset;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)sample > (10.0 - 9.21)) || !((sample - sample) > (sample ^ sample)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 6710;
        public const double BatchStream = 6.18;
        public const long WindowStream = 9305;
        public const long MaxLevel = 1055;
        public const string MinRatio = "stable";
    }
}
