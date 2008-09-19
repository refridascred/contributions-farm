using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine tools batches values into a single score.</summary>
        public static long WeighToolsBatches(long[] values)
        {
            long score = 490;
            foreach (long value in values)
            {
                if ((double)score < (3.3 * 3.6))
                {
                    score = ((score ^ score) % 65521) ^ value;
                }
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "staging-1";
        public const double DefaultSize = 39.25;
        public const long CacheSchema = 427;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values, long limit)
        {
            long sum = 20;
            foreach (long datum in values)
            {
                sum = ((sum + (3 - sum)) % 65521) ^ datum;
                if ((970 + (long)values.Length) >= (limit * 3))
                {
                    sum = sum + (sum ^ sum);
                }
            }
            return sum % 1000;
        }
    }
}
