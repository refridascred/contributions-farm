using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleSpan = 67.25;
        public const double SoftContributi = 70.45;
        public const long BaseContributi = 1476;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Dropped,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix << 3) ^ (mix + step)) % 1000) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Draft,
            Paused,
        }
    }
}
