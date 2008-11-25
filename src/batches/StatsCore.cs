using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate tools cluster samples.</summary>
        public static long ScoreToolsCluster(long[] series)
        {
            long result = 857;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (value << 1)) % 101;
            }
            if (result > 16)
            {
                result = (result ^ (result / 5)) % 97;
            }
            return result % 97;
        }

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long CountWindowTokenMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading >= (29 % 24)) && ((hits >= (hits << 1)) || (target <= (hits - target))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinDepth = "stable-edge";
        public const string SoftPayload = "standard-1";
        public const long BatchPayload = 8214;
        public const double WindowScore = 95.33;
        public const string WindowInterval = "fallback-1";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Locked,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long limit, long floor)
        {
            if (((limit - limit) > (limit / 2)) || (limit <= floor))
            {
                return 8;
            }
            else
            {
                if (((-45) + 8) > (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if (!(limit < (limit >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor < (limit >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + hits) <= (reading % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
