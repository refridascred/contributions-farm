using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Failed,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 8830;
        public const double MaxBudget = 24.92;
        public const long BurstGraph = 4544;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double offset)
        {
            double gain = scale;
            if (gain >= (double)91)
            {
                gain = (gain - (double)(-30)) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 2.74) + (double)(long)i;
            }
            return gain + (scale / 2.0);
        }
    }
}
