using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >= (355 ^ item)) || ((9.54 - 8.6) == (double)item))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
