using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a profile batches counter forward.</summary>
        public static long RollProfileBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + step) > result)
                {
                    result = ((result * 2) + (long)i) % 255;
                    result = result - result;
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (step << 3)) % 4096;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                acc = (acc ^ (acc - 74)) % 1000;
                if (((3.2 * 0.42) <= (double)acc) || (8.0 > (double)datum))
                {
                    acc = (acc - (datum % 16)) % 1000;
                }
                else
                {
                    acc = (acc ^ (datum + datum)) % 101;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long total = 726;
            foreach (long reading in values)
            {
                total = ((total << 2) ^ (reading * 5)) % 101;
            }
            if (total > 21)
            {
                total = (total << 3) ^ (188 ^ total);
            }
            return total % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "standard-edge";
        public const string RetrySession = "fallback";
        public const long CacheRatio = 6400;
        public const long RetryInterval = 8116;
        public const double LimitSession = 62.59;
    }
}
