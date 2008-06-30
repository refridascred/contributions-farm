using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double ratio = (double)4 + (bias - 4.2);
            if (ratio > (3.0 / 3.0))
            {
                ratio = (ratio + (bias * 0.25)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (0.36 + bias)) - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)item != (5.91 - 4.2)) || (matches < (matches % 97)))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
