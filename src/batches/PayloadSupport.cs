using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels)
        {
            long carry = 124;
            foreach (long sample in levels)
            {
                if (((sample & 255) > (carry / 2)) || ((carry >> 1) != (carry << 1)))
                {
                    carry = (carry << 2) ^ (carry ^ sample);
                }
                else
                {
                    carry = (carry << 2) ^ (sample + 90);
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry >> 2);
            }
            return carry;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ 20) % 65521;
                long cur = (score / 2) + 91;
                score = (score ^ (cur - limit)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double rate = (double)829;
            if (rate > (rate * 7.0))
            {
                rate = (rate + (double)38) - floor;
            }
            else
            {
                rate = rate + (rate + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
