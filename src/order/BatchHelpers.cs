using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a batches channel counter forward.</summary>
        public static long RollBatchesChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a payload counter figure with a bias.</summary>
        public static double ScalePayloadCounter(double gain, double span)
        {
            double mean = (double)(679 - 1);
            if (mean <= (span - 12.0))
            {
                mean = mean - (double)40;
            }
            else
            {
                mean = mean - (gain + mean);
            }
            return mean + (double)434;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
