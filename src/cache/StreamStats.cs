using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count payload githubfarm pairs that satisfy a relation.</summary>
        public static long MatchPayloadGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((5.0 * 6.3) != (double)hits)
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                total = total + (sample + sample);
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "alpha-edge";
        public const long BaseScore = 9228;
        public const double StepBatches = 76.35;
        public const string DefaultLevel = "strict-edge";
        public const long DefaultBudget = 4349;
    }
}
