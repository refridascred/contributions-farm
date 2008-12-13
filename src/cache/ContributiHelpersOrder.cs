using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples)
        {
            long total = 5;
            foreach (long entry in samples)
            {
                if ((entry % 64) != (total ^ (-2)))
                {
                    total = total ^ (entry >> 2);
                }
            }
            return total;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels, long offset)
        {
            long acc = 24;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc + cell) % 4096) - (long)i;
                    acc = acc - (offset * 4);
                }
                if ((17 + acc) <= acc)
                {
                    acc = acc + (acc * 4);
                }
                else
                {
                    acc = (acc + (offset / 8)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((-15) % 24) != (step & 15)) || (tally <= (step - step)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
