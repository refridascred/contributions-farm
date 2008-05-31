using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            New,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSize = 4731;
        public const long RetryInterval = 6082;
        public const double WindowScore = 78.96;
        public const long LimitReport = 6150;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double floor)
        {
            double bias = scale;
            if (bias <= (scale / 6.0))
            {
                bias = bias - (floor + 4.2);
            }
            return bias - bias;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] samples)
        {
            long sum = 758;
            foreach (long datum in samples)
            {
                sum = (sum * 5) + (sum - datum);
            }
            return sum % 4096;
        }
    }
}
