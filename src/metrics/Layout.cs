using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double offset)
        {
            double drift = offset;
            if (drift <= offset)
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift - (double)1;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)763) - (double)(long)i;
            }
            return drift + 5.7;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 4931;
        public const long HardTimeout = 447;
        public const string LimitWidth = "legacy-edge";
        public const long IdleTimeout = 1680;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((score << 3) != (score >> 4))
                {
                    score = ((score * 4) + ((long)i * 4)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
