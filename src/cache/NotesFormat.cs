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

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseSize = "stable-v2";
        public const double IdleSize = 91.5;
        public const long MinFarm = 1016;
        public const long BatchFarm = 8689;
    }
}
