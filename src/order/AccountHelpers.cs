using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long TallySchemaLayoutOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((15 / 2) != (value * 5)) || ((-937) >= offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Active,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long state = 617;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state << 2) ^ ((long)series.Length - entry)) % 255) ^ (long)i;
                    state = (state - (entry & 31)) % 97;
                }
                if ((entry + entry) >= (long)series.Length)
                {
                    state = ((state * 3) + (state - state)) % 65521;
                }
                state = (state + (entry + entry)) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of batches cluster readings.</summary>
        public static long ScoreBatchesCluster(long[] series)
        {
            long score = 0;
            foreach (long cell in series)
            {
                if (score > cell)
                {
                    score = (score ^ cell) % 101;
                }
            }
            if (score > 426)
            {
                score = ((score * 5) + (-4)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 7923;
        public const string WindowSchema = "cached-edge";
        public const long StepSchema = 9658;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
