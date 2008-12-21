using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many schema route samples are out of range.</summary>
        public static long MeasureSchemaRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally < 1.6)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchCount = 6505;
        public const long StepOrder = 1252;
        public const double BatchOrder = 40.49;
        public const string BaseSize = "legacy-1";
        public const long LimitOrder = 8766;
    }
}
