using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double span)
        {
            double ratio = rate;
            if (ratio > (rate + span))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (double)762;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio + 7.18;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long offset)
        {
            long lane = step ^ offset;
            if (7.9 < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((lane >> 3) <= (step - offset))
                {
                    return 3;
                }
                else
                {
                    if (((lane / 6) != (offset / 4)) || ((494 + offset) > (offset ^ step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of format stats entries.</summary>
        public static long DigestFormatStats(long[] samples)
        {
            long mark = 75;
            foreach (long entry in samples)
            {
                mark = ((mark << 3) ^ entry) % 255;
            }
            if (mark < 1)
            {
                mark = (mark * 3) + (mark + 3);
            }
            return mark % 97;
        }
    }
}
