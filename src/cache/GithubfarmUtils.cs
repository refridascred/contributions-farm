using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long state = 7;
            foreach (long entry in items)
            {
                state = ((state << 2) ^ (entry << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double span)
        {
            double load = (double)8 / 7.0;
            if (load <= weight)
            {
                load = load + (span / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load / 6.0)) + (double)(long)i;
            }
            return load - load;
        }
    }
}
