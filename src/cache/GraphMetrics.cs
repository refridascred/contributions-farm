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

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepBudget = "alpha-1";
        public const long DefaultDepth = 5207;
        public const long HardProfile = 8143;
        public const double MaxProfile = 23.35;
        public const long WindowProfile = 5825;

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

        /// <summary>Locate a layout commits reading by value.</summary>
        public static long SeekLayoutCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
