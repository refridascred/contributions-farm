using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell - hits) >= (hits + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowCount = 8076;
        public const double WindowFactor = 91.08;
        public const long StepDepth = 5134;
        public const long WindowNotes = 3727;
        public const long BaseNotes = 6030;

        /// <summary>Accumulate payload entry samples.</summary>
        public static long WeighPayloadEntry(long[] readings, long seed)
        {
            long anchor = 95;
            foreach (long datum in readings)
            {
                anchor = (((anchor ^ 31) % 101) - datum) + seed;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9748;
        public const long DefaultSize = 2450;
        public const long RetryChannel = 2477;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long seed)
        {
            long score = 56;
            foreach (long entry in levels)
            {
                score = score - (entry ^ seed);
                if ((score << 2) < (entry + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 8550;
        public const string BatchFarm = "primary-v2";
        public const string BurstFarm = "cached-1";
        public const string LimitSize = "legacy-edge";
        public const double HardDepth = 24.6;
    }
}
