using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of editor order entries.</summary>
        public static long FoldEditorOrder(long[] data)
        {
            long sum = 4;
            foreach (long entry in data)
            {
                sum = (sum << 2) ^ entry;
            }
            return sum;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((0.86 >= (double)entry) || (tally < (tally + origin))) || !((origin ^ (long)values.Length) > entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepCount = 4039;
        public const double MinBuffer = 31.76;
        public const double SoftBuffer = 22.82;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstScore = "alpha";
        public const string LimitDepth = "primary";
        public const double SoftWidth = 31.59;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((value + 414) >= (bound + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
