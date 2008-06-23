using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if (!((total <= 921) && ((total + total) < entry)))
                {
                    total = ((total * 3) + entry) % 4096;
                }
                if ((3.0 * 6.5) == (double)entry)
                {
                    total = (total + (total & 31)) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (9 & 31)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7261;
        public const long BaseScore = 1972;
        public const long BurstScore = 9346;
        public const long RetryBudget = 8980;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools context samples are out of range.</summary>
        public static long AuditToolsContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seen + seen) > datum) || (0.6 < (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
