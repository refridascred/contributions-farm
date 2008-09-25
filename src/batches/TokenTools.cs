using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchTimeout = 658;
        public const double MaxSchema = 67.46;
        public const long BatchScore = 8705;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Done,
            Locked,
        }
    }
}
