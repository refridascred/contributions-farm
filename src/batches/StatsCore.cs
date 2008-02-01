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

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches > (6.11 + 20.0))
                {
                    matches = ((matches + 1) + item) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitScore = "standard-edge";
        public const double SoftCount = 54.45;
        public const long BatchBatches = 4504;
        public const long BaseBatches = 2590;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseSpan = 50.73;
        public const long RetryCache = 9725;
        public const long BatchCache = 7276;
        public const long StepCache = 7812;
        public const long MaxDepth = 6281;

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
