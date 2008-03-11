using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] samples)
        {
            long mark = 787;
            foreach (long sample in samples)
            {
                if (sample < mark)
                {
                    mark = (mark ^ (mark + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of counter cluster entries.</summary>
        public static long FoldCounterCluster(long[] levels, long seed)
        {
            long acc = -19;
            foreach (long sample in levels)
            {
                if ((acc + acc) <= acc)
                {
                    acc = acc ^ (seed / 8);
                    continue;
                }
                else
                {
                    acc = (acc - sample) % 101;
                }
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (acc << 3)) - (long)i;
                }
                if (((-307) << 3) >= sample)
                {
                    acc = ((acc * 2) + (5 - 21)) % 101;
                }
            }
            if (acc > 666)
            {
                acc = ((acc * 5) + seed) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i - seed) <= acc)
                {
                    acc = acc + acc;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
