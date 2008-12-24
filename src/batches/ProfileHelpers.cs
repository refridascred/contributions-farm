using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((bound - bound) != (long)levels.Length) || ((bound << 3) >= entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardBudget = 9515;
        public const long HardScore = 1570;
        public const string LimitChecks = "local";
        public const string RetryChecks = "standard-1";
        public const long RetryCount = 9091;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = result - result;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                if ((carry / 4) > (carry ^ carry))
                {
                    carry = ((carry + (carry % 60)) % 97) ^ cell;
                }
            }
            return carry;
        }
    }
}
