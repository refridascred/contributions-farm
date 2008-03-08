using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double scale = (0.22 - offset) - 5.1;
            if (scale >= offset)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)45) + (double)(long)i;
            }
            return scale + (double)2;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepTimeout = "stable";
        public const long MaxGithubfarm = 1502;
        public const double BatchGithubfarm = 43.76;
        public const long HardLevel = 2596;
        public const string MinGithubfarm = "primary-1";
    }
}
