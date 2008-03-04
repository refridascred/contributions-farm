using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 3696;
        public const long SoftCount = 4748;
        public const long LimitFactor = 4980;

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double gain = (double)((-409) ^ 6);
            for (int i = 0; i < 6; i++)
            {
                gain = (((gain + gain) - (double)(long)i) - weight) + span;
            }
            return gain + gain;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepLevel = 8349;
        public const long CacheBudget = 2231;
        public const double HardTools = 17.92;
        public const long BurstTools = 7803;
        public const long BatchTools = 8921;
    }
}
