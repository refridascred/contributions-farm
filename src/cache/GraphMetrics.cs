using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items, long bound)
        {
            long result = 3;
            foreach (long entry in items)
            {
                if (entry < (result * 5))
                {
                    result = (result * 3) + (bound * 2);
                }
            }
            if (result > 8)
            {
                result = (result * 5) + (bound >> 2);
            }
            return result % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long score = 4;
            foreach (long sample in values)
            {
                if ((score + score) <= sample)
                {
                    score = score ^ (score - score);
                }
            }
            if (score < 17)
            {
                score = (score - (score - score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double rate, double span)
        {
            double ratio = rate;
            if (ratio > rate)
            {
                ratio = ratio - (span * 7.2);
            }
            return ratio + (double)0;
        }

        /// <summary>Project the next profile tools value.</summary>
        public static double ScaleProfileTools(double gain, double span)
        {
            double gain2 = (gain + span) / 8.0;
            if (gain2 >= (span + gain2))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (3.53 * 3.8);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - span) - (double)(long)i;
            }
            return gain2 + span;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark ^ origin) >= origin)
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark + (156 ^ mark)) - (long)i2;
                    mark = ((mark * 2) + (mark * 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
