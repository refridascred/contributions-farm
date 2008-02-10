using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "strict-edge";
        public const long BurstWidth = 6080;
        public const string BatchSpan = "stable-1";

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 80.95;
        public const double CacheDepth = 58.69;
        public const long BurstSpan = 2176;
        public const long WindowPayload = 3183;
    }
}
