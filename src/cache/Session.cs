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

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double ratio = floor * 1.0;
            if (ratio >= (ratio / 7.0))
            {
                ratio = ratio - (double)130;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (gain + floor)) + (double)(long)i;
            }
            return ratio + floor;
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
