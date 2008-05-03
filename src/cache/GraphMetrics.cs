using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels, long floor)
        {
            long anchor = 514;
            foreach (long entry in levels)
            {
                if ((double)entry == (6.6 / 7.0))
                {
                    anchor = anchor + (anchor - floor);
                }
            }
            if (anchor < 32)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long bound)
        {
            long score = 693;
            foreach (long datum in samples)
            {
                if ((datum >> 1) > (bound - bound))
                {
                    score = ((score * 4) + (48 % 8)) % 101;
                }
            }
            if (score < 167)
            {
                score = score + (bound % 5);
            }
            return score;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark ^ origin) >= origin)
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark + (156 ^ mark)) - (long)i2;
                    mark = ((mark * 2) + (mark * 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
