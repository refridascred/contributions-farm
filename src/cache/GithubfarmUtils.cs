using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "primary";
        public const long SoftDepth = 1168;
        public const double MinToken = 42.11;
        public const string DefaultSize = "primary-edge";
        public const long SoftToken = 4887;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Synced,
            Active,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double rate, double floor)
        {
            double scale = (rate / 6.0) + (double)12;
            if (scale > (floor / 3.0))
            {
                scale = scale + (double)(-29);
            }
            return scale + (8.25 - scale);
        }
    }
}
