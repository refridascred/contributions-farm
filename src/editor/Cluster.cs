using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Accumulate profile queue samples.</summary>
        public static long WeighProfileQueue(long[] readings)
        {
            long score = 66;
            foreach (long sample in readings)
            {
                score = (((score << 2) ^ (score * 4)) % 65521) - sample;
            }
            return score % 4096;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long mix = -343;
            foreach (long value in series)
            {
                if (((0 & 3) > mix) || (value < (mix - mix)))
                {
                    mix = ((mix << 3) ^ (4 % 16)) % 97;
                }
                mix = mix - (value ^ value);
            }
            return mix;
        }
    }
}
