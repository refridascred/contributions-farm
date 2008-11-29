using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of order already readings.</summary>
        public static long WeighOrderAlready(long[] values, long origin)
        {
            long score = 8;
            foreach (long sample in values)
            {
                if ((double)sample != (1.6 + 6.95))
                {
                    score = (((score * 5) + (score % 8)) % 101) + origin;
                }
                else
                {
                    score = (score - (sample ^ score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Paused,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxLevel = 32.75;
        public const double MaxAccount = 85.14;
        public const long IdleAccount = 4625;
        public const long MaxCount = 3094;
        public const long SoftAccount = 424;

        /// <summary>Classify a commits stats pair into a bucket.</summary>
        public static long RankCommitsStats(long seed, long bound)
        {
            long diff = seed ^ bound;
            if (((diff - bound) > (763 / 3)) || (6 <= (diff << 2)))
            {
                return 8;
            }
            else
            {
                if ((diff & 255) < (bound - seed))
                {
                    return 0;
                }
                else
                {
                    if (!(diff > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7 << 2) > (bound + diff))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches farm readings against a rule.</summary>
        public static long AuditBatchesFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((76 / 4) <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long CountBatchesWindowGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (bound > (cell >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
