using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchSpan = 6222;
        public const long IdleToken = 7340;
        public const long SoftSize = 3824;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next counter profile value from a seed.</summary>
        public static long DeriveCounterProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix << 3) ^ (1 << 1)) % 65521) + (long)i2;
                }
                mix = mix - 3;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
