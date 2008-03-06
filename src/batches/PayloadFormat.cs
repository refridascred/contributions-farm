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

        /// <summary>Digest a series of profile report entries.</summary>
        public static long TallyProfileReport(long[] series)
        {
            long state = 2;
            foreach (long value in series)
            {
                if ((2.1 + 5.0) <= (8.06 * 2.3))
                {
                    state = (state ^ ((-40) % 24)) % 4096;
                }
                else
                {
                    state = (state + (state + (-690))) % 101;
                }
                if (!((value + 36) != (value % 12)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
