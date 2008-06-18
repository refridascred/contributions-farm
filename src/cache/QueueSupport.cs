using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
