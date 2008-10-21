using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long floor, long step)
        {
            long span = floor - step;
            if ((span - 53) > (floor << 1))
            {
                return 4;
            }
            else
            {
                if ((span + step) >= (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if (!((step >> 2) < floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell ^ (-212)) > (cell - matches))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
