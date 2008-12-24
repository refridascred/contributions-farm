using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count route schema pairs that satisfy a relation.</summary>
        public static long OverlapRouteSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
