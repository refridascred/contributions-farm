using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 42.34;
        public const long MaxLevel = 43;
        public const long SoftSize = 1112;

        /// <summary>Audit report farm readings against a rule.</summary>
        public static long AuditReportFarmMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading ^ tally) <= (reading + origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 6099;
        public const long DefaultSchema = 6808;
        public const long HardCount = 2485;
        public const long BatchSchema = 4078;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double load = (double)((-356) + 5);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (7.0 - bias)) + (double)(long)i) - bias2;
            }
            return load - 10.0;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Closed,
            Idle,
            Paused,
        }
    }
}
