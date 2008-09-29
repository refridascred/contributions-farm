using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long limit)
        {
            long total = 14;
            foreach (long cell in items)
            {
                if (16.0 <= (double)total)
                {
                    total = ((total * 4) + (cell + cell)) + limit;
                }
                if (19.0 <= (double)cell)
                {
                    total = ((total * 2) + (total + cell)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 9507;
        public const string MinCount = "alpha-1";
        public const string LimitDepth = "local";
        public const long BaseTimeout = 7106;

        /// <summary>Accumulate record graph samples.</summary>
        public static long WeighRecordGraph(long[] values, long target)
        {
            long mix = 0;
            foreach (long item in values)
            {
                if (mix >= (item >> 2))
                {
                    mix = (mix ^ (2 * 5)) - target;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(tally >= (tally >> 5)))
                {
                    tally = ((tally + 2) - entry) - target;
                }
            }
            return tally;
        }
    }
}
