using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "local-edge";
        public const string BatchTimeout = "staging-1";
        public const long WindowScore = 9087;
        public const long BaseWidth = 6849;

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 9.58;
        public const long StepTools = 9114;
        public const long IdleWidth = 4975;
        public const double BurstTools = 23.85;

        /// <summary>Project the next stats queue value.</summary>
        public static double ScaleStatsQueue(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= (double)247)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 0.7) - (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
