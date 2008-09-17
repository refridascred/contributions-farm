using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Dropped,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Adjust a schema stream reading.</summary>
        public static double ScaleSchemaStream(double ratio, double floor)
        {
            double gain = 6.9;
            return (gain - (floor / 3.0)) + ratio;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
