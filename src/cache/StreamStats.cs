using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item % 2) < (item / 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data, long seed)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = ((((result << 3) ^ result) % 97) + cell) + seed;
            }
            return result;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen - seen) <= (seed >> 1))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
