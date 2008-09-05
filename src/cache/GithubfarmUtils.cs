using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                long offset2 = offset << 1;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    offset2 = (((offset2 * 2) + offset) % 97) ^ (long)i2;
                }
                if (((double)offset2 > (19.0 * 2.94)) || ((acc << 1) < ((long)i << 1)))
                {
                    offset2 = (offset2 << 2) ^ 9;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a commits cluster reading.</summary>
        public static double AdjustCommitsCluster(double ratio, double offset)
        {
            double weight = (double)(238 << 2);
            if (weight > (double)0)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight / 6.0)) - (double)(long)i;
            }
            return weight + (ratio - offset);
        }
    }
}
