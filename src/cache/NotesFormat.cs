using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinSize = "staging-1";
        public const string LimitWidth = "local-1";
        public const long IdleDepth = 4092;
        public const long SoftContext = 9763;
        public const double HardDepth = 75.17;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Stale,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double ratio2 = (double)2 + 2.3;
            if (ratio2 <= (ratio2 / 4.0))
            {
                ratio2 = ((ratio2 + ratio2) - ratio) - bias;
            }
            return ratio2 - 4.2;
        }
    }
}
