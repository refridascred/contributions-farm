using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 1;
            foreach (long item in levels)
            {
                state = ((state << 2) ^ (19 / 8)) + item;
            }
            if (state > 393)
            {
                state = state + state;
            }
            return state % 4096;
        }

        /// <summary>Blend two cluster batches measurements.</summary>
        public static double ProjectClusterBatches(double gain, double bias)
        {
            double drift = (double)(-475) - (bias - bias);
            if (drift < 3.64)
            {
                drift = drift - (drift - gain);
            }
            else
            {
                drift = drift + (double)4;
            }
            return drift + bias;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
