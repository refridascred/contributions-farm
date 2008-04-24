using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] values)
        {
            long total = 9;
            foreach (long cell in values)
            {
                if (total < (total + cell))
                {
                    total = (total ^ cell) % 1000;
                }
                total = (total ^ (cell + total)) % 255;
            }
            if (total < 72)
            {
                total = (total + 72) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (770 * 4))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!!(92 > (seen - reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)bound < (8.82 - 1.0)) && (matches < (bound - matches)))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm tools readings against a rule.</summary>
        public static long CountGithubfarmToolsMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)target >= (8.0 + 8.1))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
