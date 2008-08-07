using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRatio = 6850;
        public const string BatchRoute = "legacy-v2";
        public const long LimitRoute = 8441;
        public const string RetryRoute = "open-edge";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long mix = 9;
            foreach (long entry in items)
            {
                if ((5.3 - 8.3) == (double)entry)
                {
                    mix = mix - mix;
                }
            }
            if (mix > 831)
            {
                mix = (mix + (1 << 1)) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
