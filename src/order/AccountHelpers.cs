using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate report notes readings against a bound.</summary>
        public static bool ValidateReportNotesRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already checks entries that pass the check.</summary>
        public static long AuditAlreadyChecksGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((1.0 + 19.0) == (double)cell) && (((hits + hits) < hits) || ((double)cell >= (12.0 / 2.0))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)877)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine graph context values into a single score.</summary>
        public static long TallyGraphContext(long[] samples, long step)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                if (acc >= (acc << 2))
                {
                    acc = ((acc << 2) ^ (step << 2)) ^ reading;
                }
                else
                {
                    acc = ((acc << 3) ^ (590 + step)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((offset << 1) != (offset - score)) && ((0.52 + 2.0) >= (double)(long)i))
                {
                    score = ((score * 2) + offset) % 97;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
