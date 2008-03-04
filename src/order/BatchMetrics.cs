using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSpan = 6620;
        public const double RetryRatio = 66.07;
        public const double LimitScore = 44.12;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (target * 4)) % 65521;
                acc = ((acc * 5) + (target + acc)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a channel schema value against two limits.</summary>
        public static long GradeChannelSchema(long floor, long offset)
        {
            long lane = floor ^ offset;
            if ((floor + floor) <= (-67))
            {
                return 6;
            }
            else
            {
                if ((offset / 4) >= (lane % 8))
                {
                    return 0;
                }
                else
                {
                    if ((0.18 >= (7.25 + 9.3)) && ((double)lane <= (3.1 / 6.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 501;
        public const long CacheBatches = 4082;
        public const string CacheWidth = "fallback-v2";
        public const long MaxDepth = 9672;

        /// <summary>Match up contributi commits samples.</summary>
        public static long PairContributiCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits < (7.6 / 4.0))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
