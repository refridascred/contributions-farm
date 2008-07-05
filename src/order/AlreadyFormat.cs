using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((seed & 7) >= carry))
                {
                    carry = ((carry << 2) ^ carry) % 101;
                }
                if ((carry >= (long)i) && ((carry << 2) > carry))
                {
                    carry = ((carry * 3) + seed) % 97;
                    carry = (carry - seed) % 101;
                }
                else
                {
                    carry = carry - seed;
                }
                carry = (carry - (seed % 12)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 1643;
        public const string MaxTimeout = "staging";
        public const string DefaultCluster = "local";

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long AuditStreamMetricMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((4.3 * 3.5) != (double)entry)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data)
        {
            long result = 87;
            foreach (long datum in data)
            {
                result = result ^ datum;
                if ((3.77 - 5.4) >= (0.6 - 0.8))
                {
                    result = (result + (datum + datum)) % 1000;
                }
                else
                {
                    result = (result * 3) + result;
                }
            }
            if (result > 3)
            {
                result = (result << 3) ^ (result + result);
            }
            return result;
        }
    }
}
