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

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 9611;
        public const string DefaultLevel = "strict-edge";
        public const double MinAlready = 26.81;
    }
}
