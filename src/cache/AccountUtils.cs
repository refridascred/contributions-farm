using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const double CacheDepth = 14.51;
        public const string WindowScore = "latest-v2";
        public const long MaxFarm = 3640;
        public const double DefaultWidth = 68.4;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double bias, double offset)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = (gain - (0.24 - bias)) - offset;
            }
            return gain + gain;
        }
    }
}
