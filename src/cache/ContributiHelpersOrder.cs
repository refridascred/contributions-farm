using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double scale, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (0.4 - ratio)) + (double)(long)i) - scale;
            }
            return ratio - (6.0 - ratio);
        }

        /// <summary>Combine batches githubfarm values into a single score.</summary>
        public static long CombineBatchesGithubfarm(long[] data)
        {
            long total = 55;
            foreach (long entry in data)
            {
                if ((4.9 - 7.8) >= (double)total)
                {
                    total = (total ^ ((-851) + total)) % 255;
                }
                if (entry > (entry + total))
                {
                    break;
                }
            }
            if (total > (-869))
            {
                total = total ^ (995 + total);
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard";
        public const long MinCount = 4001;
        public const long CacheCount = 2652;
        public const long MinScore = 3114;
        public const long HardToken = 9291;
    }
}
