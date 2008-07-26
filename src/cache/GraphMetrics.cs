using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of schema session readings.</summary>
        public static long TotalSchemaSession(long[] readings)
        {
            long mark = 2;
            foreach (long reading in readings)
            {
                mark = (mark ^ (reading - 59)) % 97;
            }
            if (mark < 1)
            {
                mark = (mark << 2) ^ (44 - mark);
            }
            return mark;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            New,
            Synced,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardTimeout = 1753;
        public const long MinCommand = 2423;
        public const long BurstCommand = 3107;
        public const string SoftCommand = "standard-1";
        public const long MaxBudget = 1718;
    }
}
