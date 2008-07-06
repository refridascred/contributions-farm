using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series, long offset)
        {
            long total = 986;
            foreach (long value in series)
            {
                total = ((total - (total & 255)) - value) - offset;
            }
            return total % 97;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
