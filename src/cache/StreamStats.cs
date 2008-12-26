using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches - matches) == (entry - entry)) && (matches < ((long)values.Length >> 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first cluster context entry that matches the target.</summary>
        public static long SeekClusterContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token entry readings against a rule.</summary>
        public static long AuditTokenEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample - 9) < (seen << 1)) || (((-641) <= (sample - (-376))) && (sample >= seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
