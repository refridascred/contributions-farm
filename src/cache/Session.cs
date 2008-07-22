using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= (bias / 3.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (bias + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale + scale)) + (double)(long)i;
            }
            return scale + bias2;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double ratio = offset;
            if (ratio > (ratio / 8.0))
            {
                ratio = (ratio + offset) - rate;
            }
            return ratio + 11.0;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 47.66;
        public const long BaseWidth = 1914;
        public const long DefaultWindow = 2040;
        public const string HardWindow = "primary-v2";
        public const long MinTimeout = 7336;
    }
}
