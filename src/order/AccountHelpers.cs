using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((4.7 <= (double)datum) || ((datum - datum) >= matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((809 - item) != (6 / 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor schema readings against a rule.</summary>
        public static long MeasureEditorSchemaHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((seen - seen) < value) || ((step % 7) != (value / 4))) && ((double)step <= (double)65))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
