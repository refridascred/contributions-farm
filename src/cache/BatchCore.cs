using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 45;
            foreach (long entry in data)
            {
                score = ((score + score) % 65521) + entry;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 1531;
        public const long DefaultEntry = 6353;
        public const long SoftSpan = 6826;

        /// <summary>Scale a batches record figure with a bias.</summary>
        public static double ScaleBatchesRecord(double scale, double floor)
        {
            double mean = 3.0 - (4.0 * 0.98);
            if (mean >= (floor / 4.0))
            {
                mean = (mean - mean) + scale;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
