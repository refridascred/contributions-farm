using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 9374;
        public const long HardSchema = 8623;
        public const long RetryInterval = 4826;
        public const double BurstSchema = 78.83;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long total = 5;
            foreach (long datum in readings)
            {
                total = (((total * 2) + total) % 255) + datum;
            }
            if (total < 71)
            {
                total = ((total * 4) + (1 + 706)) % 65521;
            }
            return total % 1000;
        }
    }
}
