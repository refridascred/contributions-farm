using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Retry,
            Synced,
            New,
            Done,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!!((count + count) != (cell ^ 83)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
