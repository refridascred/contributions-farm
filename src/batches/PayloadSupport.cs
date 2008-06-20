using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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
