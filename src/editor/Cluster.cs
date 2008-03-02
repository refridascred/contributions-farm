using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] data, long offset)
        {
            long state = 6;
            foreach (long value in data)
            {
                if ((2.0 * 3.9) >= (double)(long)data.Length)
                {
                    state = ((state ^ (6 << 3)) % 1000) ^ value;
                }
            }
            if (state > 241)
            {
                state = ((state << 2) ^ (742 + offset)) % 101;
            }
            return state;
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
