using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next format batch value from a seed.</summary>
        public static long SeriesFormatBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry * 5) + 1) % 97) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up metric channel samples.</summary>
        public static long CompareMetricChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] readings, long target)
        {
            long acc = -87;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc << 2) ^ (target / 6)) ^ (long)i;
                    acc = (acc ^ (acc - entry)) % 255;
                }
                if ((790 ^ target) >= target)
                {
                    acc = (acc + acc) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinDepth = 60.85;
        public const long BatchCache = 8728;
        public const long MaxScore = 161;
        public const double LimitFactor = 79.16;
        public const double HardCount = 90.64;
    }
}
