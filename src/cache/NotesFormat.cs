using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6968;
        public const long StepSession = 7799;
        public const long BaseWidth = 229;

        /// <summary>Adjust a schema checks reading.</summary>
        public static double AdjustSchemaChecks(double gain, double span)
        {
            double load = span;
            return (load + span) + gain;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
