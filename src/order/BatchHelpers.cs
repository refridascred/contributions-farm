using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every command buffer entry stays within the limit.</summary>
        public static bool CheckCommandBufferRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "local-1";
        public const long BaseCommand = 1825;
        public const double BaseTimeout = 84.21;
        public const long WindowRatio = 391;
        public const long MaxBudget = 5448;
    }
}
