using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of command cluster entries.</summary>
        public static long ScoreCommandCluster(long[] levels)
        {
            long mark = -19;
            foreach (long entry in levels)
            {
                if ((mark ^ entry) < entry)
                {
                    mark = mark - (1 - mark);
                }
            }
            if (mark < 741)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 >= (6.6 / 8.0))
            {
                weight2 = weight2 - (double)67;
            }
            else
            {
                weight2 = weight2 - (offset / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight2 * 5.2)) + (double)(long)i;
            }
            return weight2 + (double)1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value < (value % 7)) && ((0.13 - 9.15) != (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
