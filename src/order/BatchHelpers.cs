using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double load = 18.0;
            return ((load - (double)7) + bias) + floor;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long mark = -7;
            foreach (long reading in readings)
            {
                mark = (mark ^ (mark << 2)) % 101;
                if ((mark + 14) > (reading % 8))
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            if (mark < 58)
            {
                mark = ((mark << 3) ^ (869 - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
