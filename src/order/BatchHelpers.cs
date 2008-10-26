using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ limit) % 1000;
                if (sum > (limit * 3))
                {
                    sum = ((sum << 2) ^ ((long)i / 9)) % 97;
                    sum = (sum ^ (75 + 816)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the support commits entries that pass the check.</summary>
        public static long TallySupportCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (seen - seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
