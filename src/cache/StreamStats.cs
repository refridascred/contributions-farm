using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two batch token measurements.</summary>
        public static double ProjectBatchToken(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + weight) - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Match up metric account samples.</summary>
        public static long CompareMetricAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Active,
            Ready,
            Dropped,
            Pending,
        }
    }
}
