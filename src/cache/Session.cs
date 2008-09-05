using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxRatio = 4449;
        public const long RetryWidth = 7096;
        public const double BatchSize = 80.78;
        public const long HardChannel = 8162;

        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long DeriveEntryLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - origin;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
