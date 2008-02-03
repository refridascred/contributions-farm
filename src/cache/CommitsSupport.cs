using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next support buffer value from a seed.</summary>
        public static long IterateSupportBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (origin * 4)) % 65521;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 < scale)
            {
                scale2 = scale2 - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + floor) - (double)(long)i;
            }
            return scale2 + (double)9;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 6015;
        public const long BaseDepth = 157;
        public const long DefaultBuffer = 4935;
        public const string BurstTimeout = "legacy-v2";
        public const string HardScore = "strict-v2";

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long bound)
        {
            long sum = 94;
            foreach (long reading in items)
            {
                if ((810 + reading) != (72 % 64))
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum + bound) % 97;
                }
            }
            if (sum < 19)
            {
                sum = sum - (sum ^ bound);
            }
            return sum;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
