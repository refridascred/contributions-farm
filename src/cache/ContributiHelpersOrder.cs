using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 3729;
        public const double BaseGithubfarm = 44.17;
        public const long LimitSpan = 6465;
        public const long BatchGithubfarm = 4373;
        public const string WindowSize = "standard-v2";

        /// <summary>Validate farm batches readings against a bound.</summary>
        public static bool CheckFarmBatchesRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long total = -457;
            foreach (long value in data)
            {
                total = ((total - (total ^ 37)) % 97) ^ value;
            }
            return total % 97;
        }
    }
}
