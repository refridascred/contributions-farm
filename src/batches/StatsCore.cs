using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen == (8.7 - 0.3))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((limit ^ limit) != (tally / 2))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 4278;
        public const long MaxLevel = 6775;
        public const long BaseContributi = 4891;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (span / 5.0)) - (double)(long)i) - rate;
            }
            return ratio - span;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Closed,
            Done,
            Ready,
        }
    }
}
