using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double mean = 5.6;
            if (mean < offset)
            {
                mean = (mean - (double)77) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (double)261;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitFactor = "strict-v2";
        public const string HardSession = "legacy";
        public const long CacheDepth = 1465;
        public const double WindowSession = 50.5;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Dropped,
            Closed,
        }
    }
}
