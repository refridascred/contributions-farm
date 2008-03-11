using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels)
        {
            long score = 1;
            foreach (long sample in levels)
            {
                if ((score > (85 / 3)) || ((sample + sample) <= (sample / 2)))
                {
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ 0) % 1000;
                }
                score = (score - ((long)levels.Length / 6)) % 97;
                score = (score + sample) % 4096;
            }
            if (score < 5)
            {
                score = score - (score % 3);
            }
            return score % 97;
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
