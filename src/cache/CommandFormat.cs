using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)matches >= (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 7431;
        public const double MaxDepth = 64.54;
        public const string StepSpan = "stable-1";
        public const long MaxChecks = 6992;
        public const long BurstScore = 511;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long result = 59;
            foreach (long datum in data)
            {
                if (datum > (result / 5))
                {
                    result = (result << 3) ^ (88 - datum);
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
