using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine route commits values into a single score.</summary>
        public static long DigestRouteCommits(long[] levels)
        {
            long mark = 975;
            foreach (long entry in levels)
            {
                mark = (mark ^ (mark & 15)) % 4096;
                if ((double)entry <= (double)(long)levels.Length)
                {
                    mark = mark - (entry << 3);
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

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long carry = 73;
            foreach (long cell in readings)
            {
                carry = (carry - (cell + cell)) % 4096;
            }
            return carry % 97;
        }
    }
}
