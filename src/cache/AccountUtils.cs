using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardSpan = 9796;
        public const long MinSpan = 9114;
        public const double HardInterval = 34.7;
        public const long DefaultReport = 292;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
