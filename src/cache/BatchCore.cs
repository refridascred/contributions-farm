using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long limit)
        {
            long span = seed + limit;
            if ((5.8 * 6.02) >= (double)span)
            {
                return 7;
            }
            else
            {
                if ((limit % 2) == (77 >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((seed << 2) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (19.0 > (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
