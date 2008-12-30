using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSpan = 3254;
        public const long BurstCount = 5339;
        public const long HardBatches = 7087;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = 5;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ (sum & 127)) % 97) - datum;
            }
            return sum;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long limit, long floor)
        {
            long cur = limit + floor;
            if ((cur + (-22)) < (limit << 1))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) == (825 << 1))
                {
                    return 8;
                }
                else
                {
                    if (!(cur < (limit % 100)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
