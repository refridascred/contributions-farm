using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen + (long)levels.Length) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count > 8.1)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long seed)
        {
            long sum = -20;
            foreach (long reading in samples)
            {
                sum = ((sum + (0 % 16)) % 101) + reading;
            }
            if (sum < 71)
            {
                sum = (sum - (seed * 5)) % 101;
            }
            return sum % 65521;
        }
    }
}
