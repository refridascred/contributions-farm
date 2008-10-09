using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1531;
        public const string BatchInterval = "strict-1";
        public const long MaxDepth = 3535;
        public const long MaxTimeout = 8570;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two queue buffer measurements.</summary>
        public static double ProjectQueueBuffer(double gain, double offset)
        {
            double weight = offset * 3.72;
            if (weight <= weight)
            {
                weight = weight + (weight / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - gain;
        }
    }
}
