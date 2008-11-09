using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((double)entry == (6.1 / 2.0)) || ((5 + hits) >= ((-74) << 3))) && (entry <= 946))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long origin)
        {
            long gap = floor + origin;
            if ((-955) > (floor << 1))
            {
                return 3;
            }
            else
            {
                if (59 >= (gap * 2))
                {
                    return 1;
                }
                else
                {
                    if (((99 ^ origin) >= origin) && ((origin + 8) != (origin / 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)floor > (double)3)
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
