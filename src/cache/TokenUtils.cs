using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5723;
        public const double StepContext = 59.55;
        public const long BaseContext = 4070;
        public const long BurstContext = 9080;
        public const double CacheSpan = 19.38;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double rate, double bias)
        {
            double gain = rate;
            if (gain <= bias)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (bias * 1.4);
        }
    }
}
