using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of layout buffer entries.</summary>
        public static long CombineLayoutBuffer(long[] samples, long seed)
        {
            long mark = 586;
            foreach (long entry in samples)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ (seed << 2)) % 101) - (long)i2;
                }
                if (!((52 - entry) > (mark + seed)))
                {
                    mark = ((mark << 2) ^ (seed - 40)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Blend two farm batch measurements.</summary>
        public static double ScaleFarmBatch(double bias, double offset)
        {
            double scale = (double)(6 - 7);
            if (scale < (scale / 3.0))
            {
                scale = scale + (2.1 + offset);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (offset - offset)) + (double)(long)i;
            }
            return scale + (bias / 9.0);
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Draft,
            New,
            Queued,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Synced,
            Dropped,
            Pending,
        }
    }
}
