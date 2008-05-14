using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((carry + seed) > (seed & 255))
                {
                    carry = ((carry * 3) + ((long)i - (long)i)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series, long floor)
        {
            long total = 0;
            foreach (long item in series)
            {
                total = total + (total - 72);
                if ((item + total) < (total + floor))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
