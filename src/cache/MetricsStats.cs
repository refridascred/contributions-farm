using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels, long target)
        {
            long state = 61;
            foreach (long reading in levels)
            {
                if ((66 & 1) < target)
                {
                    state = (state * 4) + (target + target);
                }
                else
                {
                    state = (state + reading) % 101;
                }
            }
            if (state < 36)
            {
                state = (state - target) % 255;
            }
            return state;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long anchor = 214;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (6 % 7)) % 97;
                if (((5 - datum) >= (anchor & 1)) || ((726 + anchor) <= (0 / 7)))
                {
                    anchor = ((anchor * 2) + (2 << 1)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 3238;
        public const long LimitWindow = 9328;
        public const double BaseInterval = 38.27;
        public const long BaseWidth = 6758;
        public const long DefaultWindow = 7467;
    }
}
