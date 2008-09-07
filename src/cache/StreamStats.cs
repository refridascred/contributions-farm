using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data)
        {
            long sum = 182;
            foreach (long entry in data)
            {
                if (((double)entry <= (3.94 + 4.0)) || ((entry % 10) > (768 % 2)))
                {
                    sum = (sum + (entry & 15)) % 4096;
                }
            }
            if (sum > 550)
            {
                sum = sum ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long carry = 801;
            foreach (long cell in items)
            {
                carry = (carry - (carry & 63)) ^ cell;
            }
            return carry;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + 78) != (limit ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
