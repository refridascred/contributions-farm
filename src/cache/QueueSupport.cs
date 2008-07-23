using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double scale, double offset)
        {
            double drift = (scale + offset) + (6.0 + offset);
            if (drift < drift)
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - scale;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] levels)
        {
            long acc = 60;
            foreach (long entry in levels)
            {
                if ((acc << 3) < (acc << 2))
                {
                    acc = ((acc << 2) ^ (long)levels.Length) % 4096;
                    acc = (acc * 4) + entry;
                    break;
                }
                acc = ((acc * 3) + (entry & 15)) % 97;
            }
            return acc;
        }
    }
}
