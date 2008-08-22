using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a window route reading by value.</summary>
        public static long FindWindowRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double ratio = (bias - bias) - span;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias / 3.0)) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchTimeout = "legacy-edge";
        public const long LimitEntry = 5219;
        public const string SoftEntry = "primary-edge";
        public const double RetryEntry = 25.67;
        public const long MinEntry = 8165;
    }
}
