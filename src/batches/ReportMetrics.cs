using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every batch counter entry stays within the limit.</summary>
        public static bool GuardBatchCounterRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total << 3);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of channel filter entries.</summary>
        public static long WeighChannelFilter(long[] levels)
        {
            long score = -51;
            foreach (long value in levels)
            {
                if (value < score)
                {
                    score = (score + score) % 255;
                }
            }
            return score;
        }
    }
}
