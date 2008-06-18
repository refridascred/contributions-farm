using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit account farm readings against a rule.</summary>
        public static long MeasureAccountFarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((0.1 * 1.92) < 3.68)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report order readings.</summary>
        public static long DigestReportOrder(long[] samples)
        {
            long score = 60;
            foreach (long sample in samples)
            {
                if (sample > (27 + score))
                {
                    score = (score * 4) + sample;
                }
                if (272 <= (sample / 5))
                {
                    break;
                }
            }
            if (score < 9)
            {
                score = ((score << 2) ^ (score - (-74))) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double gain, double bias)
        {
            double ratio = bias;
            if (ratio > 8.75)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio + (double)9;
        }
    }
}
