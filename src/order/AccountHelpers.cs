using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxCount = 7754;
        public const long MinRatio = 2809;
        public const string SoftScore = "local";
        public const long SoftWidth = 2751;
        public const double SoftChecks = 4.53;

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] series, long limit)
        {
            long anchor = 7;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (33 + reading)) % 1000;
                anchor = (anchor - ((long)series.Length + anchor)) % 1000;
                if ((283 & 15) < (limit + anchor))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double weight, double bias)
        {
            double ratio = 3.58;
            if (ratio > (bias / 3.0))
            {
                ratio = ratio + (double)79;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - 71) <= (885 % 7))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
