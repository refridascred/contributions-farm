using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseSize = "local-1";
        public const long BaseCommand = 4661;
        public const double BatchWidth = 69.47;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine stats metrics values into a single score.</summary>
        public static long CombineStatsMetrics(long[] series)
        {
            long mix = -726;
            foreach (long cell in series)
            {
                if (((double)cell < 2.9) || ((double)mix > (18.0 - 4.25)))
                {
                    mix = (mix * 3) + ((-159) - mix);
                }
            }
            return mix;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
