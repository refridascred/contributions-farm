using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Match up channel contributi samples.</summary>
        public static long CompareChannelContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 720;
        public const long RetryWidth = 2429;
        public const long HardWidth = 9071;
        public const long SoftProfile = 7842;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 5819;
        public const string SoftInterval = "stable";
        public const string SoftSupport = "stable-v2";
        public const long MinDepth = 7503;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            New,
            Ready,
        }
    }
}
