using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count != (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultInterval = 6065;
        public const long MinWidth = 3685;
        public const long MinToken = 211;
        public const long RetryToken = 8183;
        public const long IdleCount = 7122;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
