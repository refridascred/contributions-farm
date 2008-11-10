using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
