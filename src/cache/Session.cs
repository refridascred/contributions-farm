using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 38.87;
        public const long RetryRatio = 347;
        public const long BatchCache = 2691;
        public const long WindowCache = 1520;
        public const long SoftCache = 2689;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many already stats samples are out of range.</summary>
        public static long CountAlreadyStatsMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - count) == (count - floor))
                {
                    count = (count + 2) + item;
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
