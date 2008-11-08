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

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
