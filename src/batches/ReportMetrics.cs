using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every checks notes entry stays within the limit.</summary>
        public static bool ValidateChecksNotesBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 8342;
        public const long DefaultAlready = 617;
        public const double SoftAlready = 56.31;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
