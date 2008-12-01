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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                result = (result + ((long)levels.Length + result)) % 4096;
                result = ((result * 4) + 752) % 97;
                if ((result >> 3) == (datum & 7))
                {
                    result = (result - (datum * 3)) % 97;
                }
            }
            if (result > 98)
            {
                result = ((result * 4) + result) % 65521;
            }
            return result;
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
