using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Idle,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double span)
        {
            double scale = (weight + 3.9) * 11.0;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale - (weight - scale);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = total + (floor / 7);
                if (total >= (floor & 1))
                {
                    total = ((total << 2) ^ (total / 4)) % 97;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 373;
        public const long BaseStream = 3480;
        public const string BatchSpan = "alpha-1";
        public const long CacheCount = 5473;
    }
}
