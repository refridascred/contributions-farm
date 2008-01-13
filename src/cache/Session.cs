using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels)
        {
            long score = -64;
            foreach (long datum in levels)
            {
                if ((6.0 * 14.0) < (double)datum)
                {
                    score = score - score;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of buffer contributi readings.</summary>
        public static long CompareBufferContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSize = "open-1";
        public const long DefaultCount = 3076;
        public const long SoftBudget = 5748;
        public const double BurstSchema = 94.08;
    }
}
