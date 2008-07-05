using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "strict-edge";
        public const string WindowCount = "standard-edge";
        public const string BaseScore = "alpha-edge";
        public const string SoftLevel = "stable";

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double floor)
        {
            double drift = (2.8 - scale) * 0.61;
            if (drift <= (drift + scale))
            {
                drift = (drift - scale) - floor;
            }
            else
            {
                drift = drift + 3.71;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (scale * 4.2)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long seed)
        {
            long state = 691;
            foreach (long cell in series)
            {
                state = ((state ^ (cell % 12)) % 101) + seed;
            }
            return state;
        }
    }
}
