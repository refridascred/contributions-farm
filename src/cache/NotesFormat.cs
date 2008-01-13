using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long origin)
        {
            long sum = -9;
            foreach (long sample in items)
            {
                if ((sample + sum) > 8)
                {
                    sum = (sum - (19 << 3)) % 4096;
                }
            }
            if (sum < 234)
            {
                sum = (sum << 3) ^ origin;
            }
            return sum;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
