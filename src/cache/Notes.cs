using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count window record pairs that satisfy a relation.</summary>
        public static long OverlapWindowRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes format samples are out of range.</summary>
        public static long AuditNotesFormatHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally < (0.71 + 2.1))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 4723;
        public const long WindowFactor = 813;
        public const string CacheStats = "standard-v2";
        public const long DefaultBudget = 7704;
        public const string RetryScore = "staging-v2";
    }
}
