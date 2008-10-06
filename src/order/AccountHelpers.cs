using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels, long limit)
        {
            long carry = 1;
            foreach (long datum in levels)
            {
                if (((double)limit != (1.42 / 8.0)) && ((limit ^ datum) >= (datum + carry)))
                {
                    carry = (carry - (carry % 16)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Queued,
            Stale,
            New,
        }
    }
}
