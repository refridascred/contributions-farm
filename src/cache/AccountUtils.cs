using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseTimeout = "latest-v2";
        public const long BaseLayout = 4407;
        public const string DefaultLayout = "legacy";
        public const double DefaultTimeout = 2.15;
        public const long BaseRatio = 8587;

        /// <summary>Locate a command entry reading by value.</summary>
        public static long FindCommandEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
