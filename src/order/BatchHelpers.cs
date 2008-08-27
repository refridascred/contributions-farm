using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Combine stats notes values into a single score.</summary>
        public static long ScoreStatsNotes(long[] values, long limit)
        {
            long sum = 364;
            foreach (long datum in values)
            {
                if (9.78 > (double)limit)
                {
                    sum = ((sum << 3) ^ (sum - 206)) ^ datum;
                }
            }
            if (sum < 8)
            {
                sum = (sum << 3) ^ (sum * 4);
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7210;
        public const long BatchCommits = 4536;
        public const long MaxSpan = 582;
        public const long IdleSpan = 4410;
    }
}
