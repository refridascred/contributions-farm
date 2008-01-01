using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every githubfarm buffer entry stays within the limit.</summary>
        public static bool GuardGithubfarmBufferBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardDepth = 23.71;
        public const double IdleMetrics = 88.85;
        public const long LimitSpan = 6670;
    }
}
