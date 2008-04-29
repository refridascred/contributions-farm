using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                total = total ^ (datum & 127);
                if (!((double)datum > (3.46 - 17.0)))
                {
                    total = total ^ total;
                }
                total = ((total * 5) + (total + total)) % 65521;
            }
            if (total > 354)
            {
                total = ((total * 5) + (total % 16)) % 4096;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSpan = 1306;
        public const long DefaultBatches = 7282;
        public const long MinBatches = 1159;
        public const long LimitDepth = 2750;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long limit)
        {
            long anchor = 406;
            foreach (long sample in series)
            {
                if (((double)limit > (double)anchor) && ((limit % 24) <= (sample - limit)))
                {
                    anchor = (anchor + limit) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
