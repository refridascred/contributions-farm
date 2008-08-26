using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 3728;
        public const long BatchStats = 5504;
        public const double DefaultStats = 46.8;
        public const string MinRatio = "staging-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSize = "stable-edge";
        public const long BurstSupport = 4545;
        public const double BatchSupport = 94.47;
        public const long BaseLevel = 9314;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
