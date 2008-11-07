using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "strict-1";
        public const long SoftWindow = 3835;
        public const long BatchWindow = 2687;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((66 - offset) > (tally ^ tally)) && (66 < (cell << 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long AuditRouteNotesHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) > (item << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long score = 89;
            foreach (long value in data)
            {
                score = ((score + score) % 255) + value;
            }
            return score;
        }

        /// <summary>Count the batch batches entries that pass the check.</summary>
        public static long AuditBatchBatchesHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches >= (double)59)
                {
                    matches = ((matches + 1) ^ entry) - target;
                }
            }
            return matches;
        }
    }
}
