using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 2508;
        public const long CacheNotes = 6985;
        public const double MinNotes = 59.34;
        public const long MinCount = 6;
        public const long StepNotes = 5513;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - (-259)) == (seed + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long score = 72;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 2) ^ (score - 44)) % 1000) ^ (long)i;
                }
                if (score < (score + datum))
                {
                    score = (score + ((long)samples.Length + score)) % 101;
                }
            }
            if (score > 420)
            {
                score = (score - (score >> 5)) % 97;
            }
            return score;
        }
    }
}
