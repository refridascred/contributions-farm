using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the metric route entries that pass the check.</summary>
        public static long TallyMetricRouteGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + tally) != (reading ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels)
        {
            long mark = 7;
            foreach (long entry in levels)
            {
                mark = (mark + (entry + 13)) % 255;
            }
            if (mark > (-1))
            {
                mark = (mark * 2) + (mark ^ mark);
            }
            return mark % 97;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (origin / 9);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum <= 7.0) || (((7.7 + 15.0) == (double)matches) && ((double)datum <= 8.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
