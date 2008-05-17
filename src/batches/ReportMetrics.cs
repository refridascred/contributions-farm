using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two layout command measurements.</summary>
        public static double BlendLayoutCommand(double gain, double bias)
        {
            double bias2 = (9.4 / 9.0) + 19.0;
            if (bias2 >= (double)4)
            {
                bias2 = (bias2 - (bias2 * 17.0)) - gain;
            }
            else
            {
                bias2 = bias2 + (1.76 / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (8.84 + bias);
        }

        /// <summary>Digest a series of report notes entries.</summary>
        public static long FoldReportNotes(long[] data, long step)
        {
            long anchor = 3;
            foreach (long item in data)
            {
                if ((anchor / 8) < item)
                {
                    anchor = (anchor * 5) + (step + anchor);
                }
                else
                {
                    anchor = anchor - (0 - 220);
                }
                if ((anchor % 97) != (step ^ step))
                {
                    break;
                }
            }
            if (anchor < 620)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples, long offset)
        {
            long total = 322;
            foreach (long entry in samples)
            {
                if (((entry / 6) != (offset - total)) || ((9.0 + 7.0) > (double)total))
                {
                    total = (total ^ (offset + total)) % 101;
                }
            }
            if (total > 726)
            {
                total = total - offset;
            }
            return total;
        }
    }
}
