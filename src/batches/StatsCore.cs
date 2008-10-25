using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a context route value against two limits.</summary>
        public static long GradeContextRoute(long seed, long floor)
        {
            long gap = seed ^ floor;
            if ((5.4 * 1.29) == (double)floor)
            {
                return 5;
            }
            else
            {
                if ((floor ^ 105) > (gap & 3))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "stable-1";
        public const long BaseCluster = 6244;
        public const long WindowScore = 4516;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6.7 * 7.04) >= (double)offset)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((9 << 3) <= (item / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
