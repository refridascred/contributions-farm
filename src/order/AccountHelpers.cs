using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6905;
        public const long StepChannel = 7053;
        public const long SoftChannel = 9295;
        public const long WindowInterval = 2581;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long origin)
        {
            if ((double)bound == (double)origin)
            {
                return 3;
            }
            else
            {
                if (origin > (origin >> 5))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double load = 3.3;
            if (load > (9.78 / 7.0))
            {
                load = (load + span) - gain;
            }
            return load - (17.0 + load);
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            New,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            New,
            Active,
            Pending,
            Ready,
        }
    }
}
