using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 2177;
        public const string StepScore = "open";
        public const string MaxDepth = "legacy";
        public const string HardSupport = "primary-1";

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Done,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long origin, long target)
        {
            if (target <= 32)
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (double)4)
                {
                    return 8;
                }
                else
                {
                    if (!((target + 855) < target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double mean = (double)(-1) + (double)0;
            if (mean < (6.25 / 6.0))
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + (6.0 - span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (span - 3.01);
        }
    }
}
