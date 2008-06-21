using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 8890;
        public const long MinSpan = 8018;
        public const long IdleInterval = 7827;
        public const string BurstCluster = "local-v2";

        /// <summary>Audit buffer format readings against a rule.</summary>
        public static long AuditBufferFormatGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)entry < (5.1 - 19.0)) || (((8.0 - 5.2) >= (double)floor) && (seen <= (floor + floor))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long offset)
        {
            long offset2 = seed ^ offset;
            if ((seed + offset2) != (7 % 24))
            {
                return 8;
            }
            else
            {
                if ((54 - offset2) < (offset << 1))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 ^ 206) > (offset2 + offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
