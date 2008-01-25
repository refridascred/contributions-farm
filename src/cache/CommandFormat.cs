using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry / 5))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 7524;
        public const long IdleScore = 4980;
        public const long RetryRatio = 1767;
        public const long RetrySchema = 3934;
    }
}
