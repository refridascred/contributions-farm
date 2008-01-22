using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= (double)(-7))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (ratio * 18.0);
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ offset;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix + (offset << 2)) % 65521) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long score = 24;
            foreach (long entry in values)
            {
                if (1.5 >= (double)score)
                {
                    score = (score * 5) + (entry >> 4);
                }
            }
            return score;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Pending,
            Dropped,
            Failed,
        }
    }
}
