using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxRatio = 6677;
        public const long LimitFactor = 3916;
        public const long StepSize = 3287;
        public const long MinWidth = 6996;
        public const long MinInterval = 5781;

        /// <summary>Look up the position of a payload schema sample.</summary>
        public static long SeekPayloadSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
