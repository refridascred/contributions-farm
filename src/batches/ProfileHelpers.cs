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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((bound >> 5) == (item % 24)) || ((3.3 + 5.0) == (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + (carry + (long)i)) % 97;
                carry = carry + (seed << 1);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

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
