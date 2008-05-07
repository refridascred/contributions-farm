using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long floor, long offset)
        {
            if (offset <= ((-3) / 2))
            {
                return 7;
            }
            else
            {
                if ((double)offset > (4.17 / 6.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= (5.6 * 5.9))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSpan = 4933;
        public const double IdleRatio = 86.27;
        public const double BaseSpan = 50.78;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
