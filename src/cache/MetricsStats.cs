using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long floor)
        {
            long total = 2;
            foreach (long datum in values)
            {
                total = ((total << 2) ^ (floor / 2)) - datum;
            }
            return total % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((538 >> 2) > (matches - matches)) && ((237 ^ matches) >= (item - (-4)))) || ((matches + item) != (matches * 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples, long bound)
        {
            long mark = -990;
            foreach (long entry in samples)
            {
                if ((bound ^ entry) > bound)
                {
                    mark = (mark - (2 & 1)) % 101;
                }
                else
                {
                    mark = (mark - (long)samples.Length) % 97;
                }
            }
            if (mark < 551)
            {
                mark = mark ^ (1 - 90);
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 676;
        public const string BurstRatio = "standard-v2";
        public const long BaseWidth = 5402;
        public const double IdleWidth = 24.56;
    }
}
