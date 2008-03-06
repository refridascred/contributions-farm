using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 4648;
        public const double SoftEditor = 1.83;
        public const long CacheTimeout = 3933;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] readings, long limit)
        {
            long mix = -7;
            foreach (long item in readings)
            {
                mix = (((mix ^ 436) % 101) - item) - limit;
            }
            return mix;
        }
    }
}
