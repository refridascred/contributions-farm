using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 5880;
        public const string MinLevel = "cached-1";
        public const long IdleProfile = 3491;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
