using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double scale, double span)
        {
            double load = span;
            for (int i = 0; i < 4; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (double)1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((15.0 * 7.77) == (double)item) || !((double)limit < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
