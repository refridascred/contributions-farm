using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultSize = 8471;
        public const double StepWidth = 5.6;
        public const long BaseFactor = 4035;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 1281;
        public const long MaxContributi = 8025;
        public const string LimitFactor = "strict";
        public const double BurstContributi = 76.22;
        public const string RetryContributi = "local-1";
    }
}
