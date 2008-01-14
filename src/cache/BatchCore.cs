using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout batches readings.</summary>
        public static long TotalLayoutBatches(long[] levels, long origin)
        {
            long score = 4;
            foreach (long reading in levels)
            {
                if ((score * 4) != (reading - origin))
                {
                    score = ((score << 2) ^ reading) % 97;
                }
                else
                {
                    score = score - (long)levels.Length;
                }
            }
            return score;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseCount = "staging-v2";
        public const long IdleCount = 6237;
        public const string IdleStream = "staging-v2";
        public const string BatchSize = "stable-edge";
        public const long MinBudget = 3950;
    }
}
