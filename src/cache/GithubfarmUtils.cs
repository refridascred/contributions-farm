using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSpan = 6174;
        public const long HardSchema = 3998;
        public const long MaxSchema = 436;
        public const long StepSchema = 1903;
        public const double WindowSchema = 96.33;

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double load = span - (span / 2.0);
            if (load > bias)
            {
                load = load + load;
            }
            else
            {
                load = load + (load / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (load + 1.26)) + (double)(long)i;
            }
            return load + (load + 2.38);
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSpan = 4306;
        public const long DefaultRatio = 6687;
        public const string DefaultWidth = "staging-edge";
        public const long BaseFormat = 4709;
        public const long BaseSize = 1814;
    }
}
