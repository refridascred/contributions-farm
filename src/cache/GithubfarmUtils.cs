using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double rate, double offset)
        {
            double gain = (double)((-33) ^ 7);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (double)(long)i) - rate;
            }
            return gain + (gain - offset);
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Audit profile report readings against a rule.</summary>
        public static long TallyProfileReportMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((28 * 2) < (datum << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
