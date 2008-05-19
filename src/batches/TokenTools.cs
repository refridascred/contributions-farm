using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many queue layout samples are out of range.</summary>
        public static long MeasureQueueLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum << 3) < (matches - matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
