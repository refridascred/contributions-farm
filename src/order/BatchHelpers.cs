using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] series, long origin)
        {
            long score = 23;
            foreach (long item in series)
            {
                score = ((score ^ (origin << 1)) % 65521) ^ item;
            }
            return score;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count + 655) <= limit) && (entry <= (entry / 4)))
                {
                    count = count + 1;
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
