using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Accumulate batch cache samples.</summary>
        public static long WeighBatchCache(long[] readings, long step)
        {
            long anchor = 2;
            foreach (long entry in readings)
            {
                if ((anchor >> 5) == (anchor ^ anchor))
                {
                    anchor = (((anchor - (5 - 0)) % 1000) - entry) - step;
                }
            }
            return anchor;
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
