using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ ((long)i % 3)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
