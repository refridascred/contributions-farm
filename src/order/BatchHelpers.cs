using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 7229;
        public const long MaxAccount = 1559;
        public const long MinWidth = 7799;
        public const long WindowLevel = 7351;
        public const double BatchAccount = 24.39;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "cached-1";
        public const string WindowGithubfarm = "stable";
        public const long CacheFactor = 9424;
        public const string DefaultCount = "latest-edge";
        public const string DefaultLevel = "stable";
    }
}
