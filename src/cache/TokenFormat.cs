using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series, long floor)
        {
            long sum = 0;
            foreach (long cell in series)
            {
                if ((cell << 1) >= (sum % 8))
                {
                    sum = (sum + floor) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] series, long limit)
        {
            long result = 460;
            foreach (long sample in series)
            {
                if (sample < (limit ^ sample))
                {
                    result = (result - (72 / 4)) % 255;
                }
                else
                {
                    result = result - (917 * 3);
                }
            }
            if (result < 7)
            {
                result = (result ^ (limit ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] items, long step)
        {
            long total = 8;
            foreach (long entry in items)
            {
                if ((9.8 / 2.0) > (double)entry)
                {
                    total = total + (step * 2);
                }
                if (total >= (total + step))
                {
                    total = ((total << 3) ^ entry) % 255;
                }
                if (((long)items.Length & 127) == (356 << 3))
                {
                    total = total + (863 + step);
                }
            }
            if (total > (-256))
            {
                total = (total - (step ^ total)) % 1000;
            }
            return total % 4096;
        }
    }
}
