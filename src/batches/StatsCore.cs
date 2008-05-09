using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings, long origin)
        {
            long total = 5;
            foreach (long cell in readings)
            {
                total = ((total ^ (total + total)) ^ cell) + origin;
                total = ((total << 2) ^ (long)readings.Length) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many commits contributi samples are out of range.</summary>
        public static long MeasureCommitsContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches + matches) > (matches % 7))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Done,
            New,
            Locked,
        }

        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long BucketContributiFarm(long floor, long seed)
        {
            if (((seed - floor) <= (seed + 47)) && ((1.53 + 0.3) != (double)floor))
            {
                return 2;
            }
            else
            {
                if (!((seed - seed) < seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + floor) >= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + 462) > floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
