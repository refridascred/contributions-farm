using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                if (4.0 <= (double)sum)
                {
                    sum = ((sum * 2) + (sum - (-1))) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardSpan = "cached-1";
        public const long IdleCluster = 9900;
        public const long MaxCluster = 7682;
        public const double DefaultWidth = 90.62;

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
