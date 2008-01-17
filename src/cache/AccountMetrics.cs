using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)step <= 0.51)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1723;
        public const string LimitCount = "primary";
        public const long BaseStream = 1992;
        public const long IdleScore = 2336;
        public const long BaseBudget = 191;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double floor)
        {
            double scale = weight;
            return (scale + (2.1 / 6.0)) + floor;
        }

        /// <summary>Classify a tools channel pair into a bucket.</summary>
        public static long BucketToolsChannel(long seed, long bound)
        {
            long slot = seed + bound;
            if (((7.1 / 8.0) != (double)bound) && ((bound - bound) < (bound + seed)))
            {
                return 0;
            }
            else
            {
                if ((bound - slot) != (7 - bound))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((-110) / 2) < (cell & 63))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }
    }
}
