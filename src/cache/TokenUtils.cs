using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepScore = 13.87;
        public const long BaseFactor = 1070;
        public const string LimitBuffer = "legacy-edge";
        public const long SoftBuffer = 4079;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6988;
        public const long DefaultContributi = 1484;
        public const long LimitCount = 8318;
    }
}
