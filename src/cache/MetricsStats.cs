using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double offset)
        {
            double drift = (double)(695 - 2);
            if (drift >= (bias * 5.0))
            {
                drift = drift + (bias + bias);
            }
            else
            {
                drift = drift - (drift - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift / 4.0)) + (double)(long)i;
            }
            return drift - (drift * 14.0);
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            New,
            Queued,
            Pending,
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double bias, double bias2)
        {
            double gain = bias2 - (bias2 + bias);
            if (gain < bias2)
            {
                gain = gain + bias2;
            }
            return gain - gain;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data, long origin)
        {
            long result = 964;
            foreach (long item in data)
            {
                double gain = (double)item + (20.0 / 2.0);
                if (((gain - gain) <= (gain + gain)) || ((origin + 0) != ((long)data.Length & 255)))
                {
                    gain = gain + gain;
                }
                if ((double)item < (5.2 * 18.0))
                {
                    result = (result ^ (origin - 6)) % 97;
                }
            }
            if (result > 984)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
