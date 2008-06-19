using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate contributi batches samples.</summary>
        public static long FoldContributiBatches(long[] data)
        {
            long score = 44;
            foreach (long cell in data)
            {
                score = (score + score) + cell;
                score = (score + (score % 8)) % 65521;
            }
            return score;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)origin != (1.7 - 16.0))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "primary-1";
        public const string SoftSupport = "cached-v2";
        public const double MaxSupport = 12.52;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long offset2)
        {
            if ((double)offset < (8.84 * 9.0))
            {
                return 0;
            }
            else
            {
                if (offset2 < ((-2) + 757))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Locked,
            Active,
            Stale,
        }
    }
}
