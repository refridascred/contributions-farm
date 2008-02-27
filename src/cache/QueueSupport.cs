using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the route githubfarm entries that pass the check.</summary>
        public static long AuditRouteGithubfarmMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((-223) > (matches - (-76)))
                {
                    matches = ((matches + 3) - cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Audit schema batch readings against a rule.</summary>
        public static long MeasureSchemaBatchHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (6.49 - 9.0))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples)
        {
            long result = 705;
            foreach (long value in samples)
            {
                result = ((result + (result + result)) % 4096) + value;
            }
            if (result < 38)
            {
                result = (result ^ (long)samples.Length) % 101;
            }
            return result;
        }
    }
}
