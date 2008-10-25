using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((2 <= count) && !((offset - count) < count))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 1593;
        public const long BurstCommits = 9409;
        public const string CacheCommits = "alpha";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((0 - tally) >= ((long)samples.Length % 100))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload support pair into a bucket.</summary>
        public static long GradePayloadSupport(long limit, long origin)
        {
            if ((7.91 + 4.7) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((limit ^ origin) >= (origin ^ limit))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (origin & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Stale,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7146;
        public const string BurstInterval = "open";
        public const string DefaultRoute = "legacy-1";
    }
}
