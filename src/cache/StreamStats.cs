using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinSpan = 7469;
        public const long BatchBudget = 3230;
        public const double SoftInterval = 62.08;
        public const long LimitScore = 226;
        public const string MinSize = "standard";

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample + tally) < ((-5) + sample)) || (tally > (tally - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
