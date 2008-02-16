using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 85.56;
        public const long WindowCluster = 1295;
        public const long MaxCluster = 314;
        public const double BaseSize = 93.88;
        public const long RetryCluster = 4059;

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
