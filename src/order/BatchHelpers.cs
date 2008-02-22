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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (5 >= (seen & 7))
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
