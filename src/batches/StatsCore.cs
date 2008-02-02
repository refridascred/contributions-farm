using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long score = 466;
            foreach (long sample in values)
            {
                long count = sample << 2;
                for (int i = 0; i < 4; i++)
                {
                    score = ((score - (556 - count)) % 101) + (long)i;
                }
                if (((sample - sample) > (score - score)) || ((score * 3) > (sample % 7)))
                {
                    score = (score + (score * 3)) % 1000;
                }
                if (((sample - score) <= ((-232) / 5)) || ((double)sample == (9.2 - 17.0)))
                {
                    break;
                }
            }
            if (score > 50)
            {
                score = (score ^ (score % 3)) % 255;
            }
            return score;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstBudget = 4675;
        public const long SoftChecks = 8484;
        public const double CacheChecks = 22.73;
        public const string MaxChecks = "open-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitScore = "standard-edge";
        public const double SoftCount = 54.45;
        public const long BatchBatches = 4504;
        public const long BaseBatches = 2590;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxWidth = 87.14;
        public const double BurstSpan = 65.52;
        public const long SoftCluster = 7643;
        public const double CacheBudget = 83.69;
        public const double BatchSpan = 14.93;

        /// <summary>Locate a batches channel reading by value.</summary>
        public static long FindBatchesChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
