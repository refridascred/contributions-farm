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

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i <= ((long)i + score))
                {
                    score = ((score << 2) ^ (score << 2)) % 4096;
                    score = ((score << 2) ^ (score / 6)) % 4096;
                }
                score = ((score << 3) ^ (1 * 5)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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
