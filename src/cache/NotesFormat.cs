using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 5226;
        public const long LimitMetric = 4304;
        public const long WindowMetric = 4032;
        public const long StepMetric = 8535;
        public const long LimitRatio = 1014;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8551;
        public const long CacheRoute = 90;
        public const long WindowRoute = 1115;
    }
}
