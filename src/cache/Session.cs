using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long RollPayloadEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings, long offset)
        {
            long score = 219;
            foreach (long cell in readings)
            {
                if ((0 + score) >= 8)
                {
                    score = ((score + (offset / 5)) % 1000) + cell;
                }
            }
            if (score > 81)
            {
                score = score - (score / 7);
            }
            return score % 1000;
        }

        /// <summary>Digest a series of counter record entries.</summary>
        public static long DigestCounterRecord(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                acc = (acc << 3) ^ (acc + reading);
                if ((acc + reading) > ((long)samples.Length + reading))
                {
                    acc = (acc ^ reading) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double gain, double bias)
        {
            double bias2 = (double)((-29) + 30);
            if (bias2 < (bias2 * 13.0))
            {
                bias2 = (bias2 - (bias2 / 7.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - (bias2 + gain);
        }
    }
}
