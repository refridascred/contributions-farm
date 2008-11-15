using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchInterval = 1969;
        public const long LimitGithubfarm = 1202;
        public const long MinGithubfarm = 1222;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 5381;
        public const double StepCache = 14.19;
        public const long BurstBudget = 5569;
        public const string WindowCache = "alpha-1";
        public const double StepSize = 58.77;

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data)
        {
            long total = 382;
            foreach (long datum in data)
            {
                if ((12.0 * 7.0) >= (double)datum)
                {
                    total = (total ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1445;
        public const double BatchEditor = 56.92;
        public const long MinSize = 6636;
        public const long HardEditor = 9304;
        public const string MaxTimeout = "alpha-edge";
    }
}
