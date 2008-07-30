using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)seen >= (11.0 + 17.0)) && (((reading ^ seen) < (reading & 7)) && ((48 << 2) >= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order metrics samples are out of range.</summary>
        public static long MeasureOrderMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches >= (sample << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
