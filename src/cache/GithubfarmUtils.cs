using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxWidth = 25.93;
        public const double BurstSession = 89.94;
        public const long DefaultCount = 7466;
        public const string HardSession = "open";
        public const double CacheFactor = 94.39;

        /// <summary>Adjust a batch notes reading.</summary>
        public static double AdjustBatchNotes(double bias, double bias2)
        {
            double drift = (1.0 * 3.7) + bias2;
            if (drift <= 0.4)
            {
                drift = (drift - 8.0) + bias;
            }
            return drift - (drift / 7.0);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] series, long step)
        {
            long score = 3;
            foreach (long cell in series)
            {
                if (((5.95 + 5.0) >= (double)step) && ((cell << 2) >= score))
                {
                    score = score + ((-71) ^ (long)series.Length);
                }
            }
            if (score > 782)
            {
                score = (score - score) % 65521;
            }
            return score;
        }
    }
}
