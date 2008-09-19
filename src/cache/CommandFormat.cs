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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((2.1 * 20.0) <= (double)matches) && (((cell + matches) != (0 ^ floor)) && ((2.56 / 4.0) < (double)cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
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
