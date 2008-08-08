using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples)
        {
            long mix = 326;
            foreach (long entry in samples)
            {
                if (mix >= (mix / 8))
                {
                    long matches = (817 << 1) + mix;
                    mix = (mix + (matches + matches)) % 4096;
                }
                else
                {
                    mix = (mix - mix) % 101;
                }
                if ((mix * 5) < (entry * 2))
                {
                    mix = (mix * 5) + (entry * 4);
                }
            }
            return mix;
        }

        /// <summary>Adjust a stats report reading.</summary>
        public static double ProjectStatsReport(double rate, double offset)
        {
            double bias = rate;
            if (bias > (offset - rate))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)61) + (double)(long)i;
            }
            return bias - (double)509;
        }

        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long ScoreContributiChecks(long[] samples)
        {
            long mark = 664;
            foreach (long reading in samples)
            {
                mark = (mark ^ (reading - 21)) % 4096;
            }
            if (mark > 1)
            {
                mark = mark ^ (mark & 1);
            }
            return mark;
        }
    }
}
