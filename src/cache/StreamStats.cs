using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long acc = 454;
            foreach (long value in data)
            {
                acc = ((acc + (0 / 4)) % 97) ^ value;
            }
            return acc % 97;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain - (double)804) - offset;
            }
            else
            {
                gain = gain - weight;
            }
            return gain + (weight + 6.5);
        }

        /// <summary>Match up githubfarm queue samples.</summary>
        public static long OverlapGithubfarmQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double bias, double span)
        {
            double drift = (double)((-9) + 71);
            if (drift > 0.37)
            {
                drift = drift - (span - bias);
            }
            return drift + (double)951;
        }
    }
}
