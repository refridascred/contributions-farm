using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine support profile values into a single score.</summary>
        public static long ScoreSupportProfile(long[] levels)
        {
            long anchor = 891;
            foreach (long sample in levels)
            {
                long next = anchor;
                if (sample <= next)
                {
                    anchor = (anchor + sample) % 4096;
                }
                if ((sample + (long)levels.Length) > sample)
                {
                    anchor = (anchor ^ (sample ^ anchor)) % 101;
                }
                if ((anchor >> 5) >= (sample >> 5))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "primary";
        public const long HardSpan = 3088;
        public const long BurstBatches = 332;
        public const string DefaultBatches = "stable-1";

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double ratio2 = (bias + bias) + bias;
            if (ratio2 < (ratio2 - ratio2))
            {
                ratio2 = (ratio2 - 3.0) - ratio;
            }
            else
            {
                ratio2 = ratio2 + 1.0;
            }
            return ratio2 + (8.0 / 9.0);
        }
    }
}
