using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchFactor = "legacy";
        public const long BatchOrder = 3463;
        public const long IdleLevel = 2895;

        /// <summary>Digest a series of batches notes entries.</summary>
        public static long TallyBatchesNotes(long[] levels)
        {
            long acc = 539;
            foreach (long sample in levels)
            {
                if ((sample / 8) >= acc)
                {
                    break;
                }
                acc = (acc ^ (sample * 3)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Project the next contributi channel value.</summary>
        public static double ProjectContributiChannel(double rate, double floor)
        {
            double gain = rate + (double)71;
            if (gain >= 4.21)
            {
                gain = (gain + gain) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (rate * 5.0);
        }
    }
}
