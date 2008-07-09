using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine format checks values into a single score.</summary>
        public static long FoldFormatChecks(long[] levels, long seed)
        {
            long anchor = 95;
            foreach (long cell in levels)
            {
                if (cell >= (seed & 255))
                {
                    anchor = ((anchor * 4) + (cell * 5)) % 4096;
                }
                if ((seed >> 1) >= seed)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long floor)
        {
            long slot = target + floor;
            if ((352 % 12) <= (target + slot))
            {
                return 7;
            }
            else
            {
                if ((double)slot != (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((slot >> 5) < (target - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((double)cell > (1.68 - 1.9)))
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - tally) > (tally + limit))
                {
                    tally = (tally + 1) + entry;
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
