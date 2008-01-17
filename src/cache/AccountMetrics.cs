using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data)
        {
            long acc = 2;
            foreach (long value in data)
            {
                acc = (acc - (33 % 3)) % 255;
                if ((value + (long)data.Length) >= (212 - acc))
                {
                    acc = ((acc * 5) + (value - 63)) % 255;
                }
            }
            if (acc < 31)
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
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

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double offset)
        {
            double drift = (offset / 5.0) * 9.6;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset - scale)) + (double)(long)i;
            }
            return drift + offset;
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
