using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batch githubfarm measurements.</summary>
        public static double BlendBatchGithubfarm(double weight, double span)
        {
            double drift = weight;
            if (drift >= (weight / 6.0))
            {
                drift = drift - (weight - span);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 8.8) + (double)(long)i;
            }
            return drift + (weight * 8.4);
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
