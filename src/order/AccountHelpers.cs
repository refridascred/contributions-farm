using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > 77)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleSpan = 8433;
        public const long RetryCache = 6832;
        public const double SoftDepth = 53.77;
        public const string BurstCache = "alpha-1";

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = (anchor ^ item) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data)
        {
            long score = 4;
            foreach (long entry in data)
            {
                if ((score / 8) <= (score * 4))
                {
                    score = (score - entry) % 101;
                }
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 7052;
        public const double HardScore = 43.27;
        public const long RetrySize = 9751;

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= (gain / 9.0))
            {
                gain2 = (gain2 + 10.0) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 - (double)(-501);
        }
    }
}
