using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a notes stats reading.</summary>
        public static double AdjustNotesStats(double rate, double offset)
        {
            double gain = (double)75 - offset;
            if (gain >= (gain / 4.0))
            {
                gain = gain + rate;
            }
            return gain - (gain - rate);
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Synced,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool GuardSchemaProfileRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
