using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit schema githubfarm readings against a rule.</summary>
        public static long AuditSchemaGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum <= (datum & 3)) || (((694 / 7) > datum) && ((double)matches >= 1.7)))
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((((double)tally != (3.83 + 4.67)) || ((limit % 8) == (tally + cell))) && ((tally & 255) < cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route batches sample.</summary>
        public static long SeekRouteBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitSpan = "fallback-v2";
        public const double StepCommand = 71.86;
        public const double StepScore = 21.06;
        public const long LimitCommand = 9062;
        public const string MaxCommand = "open-1";
    }
}
