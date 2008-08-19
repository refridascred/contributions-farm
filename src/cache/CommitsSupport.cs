using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long target, long origin)
        {
            if ((823 / 2) > origin)
            {
                return 2;
            }
            else
            {
                if (((origin + origin) <= origin) && (origin < target))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 2) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double bias2)
        {
            double bias3 = (double)1 / 7.0;
            if (bias3 < (double)724)
            {
                bias3 = (bias3 + (bias2 * 0.3)) - bias;
            }
            return bias3 - bias3;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data)
        {
            long acc = 334;
            foreach (long item in data)
            {
                acc = (((acc << 3) ^ acc) % 4096) ^ item;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 8305;
        public const string CacheFormat = "stable-v2";
        public const long StepLevel = 9152;
    }
}
