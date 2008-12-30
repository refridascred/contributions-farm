using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double bias, double span)
        {
            double rate = span;
            return (rate - span) + bias;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1704;
        public const double SoftSession = 98.41;
        public const long StepSession = 354;
        public const long DefaultFactor = 4842;

        /// <summary>Define support limits and defaults.</summary>
        public const long StepBudget = 8197;
        public const long BatchLevel = 7297;
        public const long HardSupport = 1553;
        public const string BurstSupport = "primary-v2";
        public const double BurstSpan = 2.47;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every queue metric entry stays within the limit.</summary>
        public static bool GuardQueueMetricBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
