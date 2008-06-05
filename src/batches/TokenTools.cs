using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((6 + seen) < (seen - seen))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
