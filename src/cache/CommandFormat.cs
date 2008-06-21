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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data)
        {
            long state = 697;
            foreach (long reading in data)
            {
                state = state - (reading + state);
                if ((state + reading) == (reading ^ (-913)))
                {
                    state = (state - (state * 4)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (state % 100)) % 65521;
                }
            }
            if (state > 7)
            {
                state = (state ^ (state / 5)) % 65521;
            }
            return state;
        }

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
