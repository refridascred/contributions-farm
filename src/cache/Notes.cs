using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((988 & 31) > (datum + (long)samples.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally * 5) >= (81 - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples)
        {
            long acc = 46;
            foreach (long sample in samples)
            {
                acc = ((acc * 4) + ((-702) ^ sample)) % 97;
            }
            if (acc < 8)
            {
                acc = acc - (acc - 636);
            }
            return acc;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length > 68) && (reading >= (reading + 412)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
