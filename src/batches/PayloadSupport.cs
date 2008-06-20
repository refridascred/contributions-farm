using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
