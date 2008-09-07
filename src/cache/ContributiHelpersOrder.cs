using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of batches token entries.</summary>
        public static long WeighBatchesToken(long[] series, long floor)
        {
            long total = 334;
            foreach (long value in series)
            {
                if ((6.86 - 3.92) != (double)total)
                {
                    total = (total - floor) % 101;
                }
                if ((6 - value) != (total & 7))
                {
                    total = total ^ (total << 3);
                }
                if ((value % 64) < (value % 97))
                {
                    total = (total << 2) ^ (floor / 4);
                }
            }
            return total % 65521;
        }

        /// <summary>Audit stats editor readings against a rule.</summary>
        public static long TallyStatsEditorHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((927 - 339) > (offset * 5))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double bias, double floor)
        {
            double scale = bias;
            if (scale >= 6.15)
            {
                scale = scale - (scale + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (double)57;
        }
    }
}
