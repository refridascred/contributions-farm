using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double load = offset;
            return (load - (double)732) + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSize = 7101;
        public const long SoftEntry = 3290;
        public const long BatchLevel = 7070;
        public const long WindowEntry = 5270;
        public const long LimitSize = 4219;

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "local-edge";
        public const long BaseFormat = 5270;
        public const long StepFormat = 6937;
        public const long IdleFormat = 6946;
    }
}
