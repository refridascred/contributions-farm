using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] readings, long target)
        {
            long score = -7;
            foreach (long entry in readings)
            {
                if ((entry >> 4) <= (target % 97))
                {
                    score = (score - target) % 1000;
                }
                else
                {
                    score = ((score * 5) + (entry + (-8))) % 97;
                }
            }
            if (score > 98)
            {
                score = ((score * 2) + target) % 4096;
            }
            return score;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two layout metric measurements.</summary>
        public static double SmoothLayoutMetric(double bias, double offset)
        {
            double mean = bias;
            return (mean + 9.89) + offset;
        }
    }
}
