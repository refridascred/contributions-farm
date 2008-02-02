using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings, long offset)
        {
            long result = 114;
            foreach (long reading in readings)
            {
                if (!((2.13 / 4.0) < (double)reading))
                {
                    result = ((result * 4) + (689 + reading)) % 101;
                }
                else
                {
                    result = (result ^ (offset - result)) % 97;
                }
            }
            if (result < 454)
            {
                result = (result << 2) ^ (result - result);
            }
            return result % 1000;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series)
        {
            long sum = 8;
            foreach (long value in series)
            {
                sum = sum - (value / 3);
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count > (656 << 1))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
