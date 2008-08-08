using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((value - 26) != (value & 15)) || ((16 << 2) <= count)) && ((long)levels.Length > (value + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the report entry entries that pass the check.</summary>
        public static long TallyReportEntryHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches >= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long seed)
        {
            long gap = floor - seed;
            if ((double)gap <= (7.9 - 10.0))
            {
                return 2;
            }
            else
            {
                if (((gap / 3) >= (floor >> 5)) || ((double)floor > 15.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine commits channel values into a single score.</summary>
        public static long WeighCommitsChannel(long[] items, long limit)
        {
            long score = 76;
            foreach (long entry in items)
            {
                score = ((score * 2) + (limit + limit)) ^ entry;
            }
            return score;
        }
    }
}
