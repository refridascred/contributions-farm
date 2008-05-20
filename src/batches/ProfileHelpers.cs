using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double gain = (offset - offset) / 8.0;
            if (gain < 13.0)
            {
                gain = (gain + (gain * 1.6)) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (offset * 6.0)) + (double)(long)i;
            }
            return gain + (offset / 2.0);
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double weight = (ratio * 13.0) / 2.0;
            return weight - offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinCount = 42.05;
        public const long HardGraph = 679;
        public const long WindowGraph = 9000;
    }
}
