using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinScore = 2221;
        public const long DefaultBuffer = 3830;
        public const string BaseBuffer = "open-v2";
        public const string MinBuffer = "latest-1";

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 3638;
        public const string HardFormat = "standard-1";
        public const long WindowScore = 1279;
        public const long MaxFormat = 4792;
        public const long LimitFormat = 3588;
    }
}
