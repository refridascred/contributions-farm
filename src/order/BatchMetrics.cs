using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3.0 - 6.1) < (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

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
