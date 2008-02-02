using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long target)
        {
            long mark = 648;
            foreach (long entry in readings)
            {
                if ((double)target < (8.35 + 5.62))
                {
                    mark = (mark + (mark + entry)) % 1000;
                }
            }
            return mark;
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
