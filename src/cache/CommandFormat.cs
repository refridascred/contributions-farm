using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many stream editor samples are out of range.</summary>
        public static long CountStreamEditorOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) <= 75)
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 0.91;
        public const long BatchWindow = 1090;
        public const long MinWindow = 5445;
        public const string RetryWindow = "local-edge";
        public const long BurstSpan = 6079;

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double ratio = rate;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + 9.0) + (double)(long)i) + offset;
            }
            return ratio + rate;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = ((state * 4) + (bound * 4)) + (long)i3;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
