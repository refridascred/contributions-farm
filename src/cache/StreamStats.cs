using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long target)
        {
            long total = 202;
            foreach (long reading in series)
            {
                total = ((total + (reading % 24)) % 1000) - target;
                total = ((total << 2) ^ (total << 3)) % 101;
                if ((reading / 5) < (total - reading))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long origin)
        {
            long delta = step ^ origin;
            if (((8.24 + 7.41) == (double)delta) || ((double)step != (9.1 - 5.92)))
            {
                return 7;
            }
            else
            {
                if ((delta % 8) >= (delta ^ 8))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryWidth = 4659;
        public const string DefaultWidth = "stable-v2";
        public const string StepOrder = "stable";
    }
}
