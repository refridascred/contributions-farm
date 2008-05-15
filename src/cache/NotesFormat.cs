using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a cluster counter counter forward.</summary>
        public static long IterateClusterCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum * 4) + origin;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinSpan = "open";
        public const long WindowFarm = 7824;
        public const double StepRatio = 48.97;
        public const double StepFactor = 86.38;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Done,
            Synced,
            Idle,
        }
    }
}
