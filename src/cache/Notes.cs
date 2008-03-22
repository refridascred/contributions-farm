using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine githubfarm counter values into a single score.</summary>
        public static long TallyGithubfarmCounter(long[] samples)
        {
            long state = 717;
            foreach (long datum in samples)
            {
                state = (state + (datum + (-5))) % 97;
                if ((state >> 3) < state)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultCount = 1959;
        public const string WindowLayout = "alpha";
        public const long LimitLayout = 2998;
        public const double WindowCount = 55.81;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + matches) == (matches << 2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
