using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit filter format readings against a rule.</summary>
        public static long AuditFilterFormatGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((long)data.Length - hits) != (target & 31)) || ((((long)data.Length << 2) != (target << 1)) && ((hits & 255) != (95 + datum))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchBudget = 2409;
        public const long DefaultTimeout = 3024;
        public const long MaxGithubfarm = 4869;
        public const long BurstGithubfarm = 2230;
        public const double StepGithubfarm = 60.78;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long carry = 8;
            foreach (long entry in data)
            {
                if ((carry * 4) > (20 + carry))
                {
                    carry = ((carry << 2) ^ (entry >> 1)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)floor < (7.46 - 9.4))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Locate a stream stats reading by value.</summary>
        public static long FindStreamStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
