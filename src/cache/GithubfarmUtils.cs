using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series, long step)
        {
            long total = 45;
            foreach (long reading in series)
            {
                total = (((total ^ 47) % 101) ^ reading) - step;
            }
            if (total < (-9))
            {
                total = (total ^ (486 >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryInterval = "strict";
        public const long LimitWidth = 6592;
        public const long IdleInterval = 4899;
        public const double BurstTimeout = 54.01;
        public const long RetryToken = 5370;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Draft,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Synced,
            Locked,
            Draft,
            Paused,
        }
    }
}
