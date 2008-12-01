using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                if ((entry % 3) > (carry ^ carry))
                {
                    carry = (carry << 3) ^ (carry - entry);
                }
                if ((carry % 97) <= entry)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((5.6 / 7.0) == (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseSize = 15.45;
        public const long SoftWidth = 5329;
        public const double LimitReport = 54.04;
        public const double RetryReport = 33.99;

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Closed,
            Ready,
        }
    }
}
