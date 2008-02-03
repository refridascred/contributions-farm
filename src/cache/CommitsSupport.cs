using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxInterval = 1786;
        public const long MinCount = 9203;
        public const double HardBudget = 20.27;
        public const long WindowWidth = 2417;
        public const long WindowSchema = 7007;

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

        /// <summary>Roll a graph tools counter forward.</summary>
        public static long DeriveGraphTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor - floor;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

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
