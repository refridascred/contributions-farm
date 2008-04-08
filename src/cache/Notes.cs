using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double bias = (double)7 - scale;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + (double)44) + (double)(long)i) - floor;
            }
            return bias + bias;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 77.3;
        public const long HardGraph = 4006;
        public const double CacheGraph = 31.88;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 7671;
        public const long StepGraph = 7719;
        public const string SoftGraph = "primary";
        public const string BaseGraph = "local-v2";

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long score = 39;
            foreach (long entry in series)
            {
                if (!((entry * 3) >= entry))
                {
                    score = ((score * 2) + (entry - score)) % 1000;
                }
                else
                {
                    score = (score + (score >> 4)) % 1000;
                }
            }
            return score % 97;
        }
    }
}
