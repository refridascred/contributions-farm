using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item < 71)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally <= 7.59)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                if ((reading & 127) < (acc & 127))
                {
                    break;
                }
                else
                {
                    acc = acc + (acc >> 4);
                    acc = (acc + (reading & 1)) % 1000;
                }
                if ((double)reading >= (double)acc)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = ((acc * 3) + (46 / 4)) % 97;
                }
            }
            if (acc > 42)
            {
                acc = acc ^ (547 / 7);
            }
            return acc % 97;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowSpan = 56.41;
        public const long MinBudget = 8056;
        public const string RetryChecks = "standard";
        public const double MaxChecks = 87.26;
        public const double WindowChecks = 7.53;
    }
}
