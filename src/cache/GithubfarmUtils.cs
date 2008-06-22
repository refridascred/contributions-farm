using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings)
        {
            long mix = 42;
            foreach (long value in readings)
            {
                if ((mix >= (value / 2)) || (7.0 <= (double)mix))
                {
                    mix = ((mix * 4) + (mix + value)) % 255;
                }
            }
            if (mix > 68)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 53.95;
        public const double IdleLevel = 50.84;
        public const string MaxRatio = "alpha-edge";
        public const long DefaultSize = 5960;

        /// <summary>Blend two command window measurements.</summary>
        public static double SmoothCommandWindow(double scale, double bias)
        {
            double rate = (scale - bias) / 7.0;
            return rate - (scale * 12.0);
        }
    }
}
