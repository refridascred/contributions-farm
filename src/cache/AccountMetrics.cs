using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "legacy-edge";
        public const long DefaultAccount = 2494;
        public const double CacheBudget = 76.69;

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleWidth = 71.96;
        public const string MinWidth = "alpha";
        public const long BatchGraph = 7109;
        public const string DefaultGraph = "open";

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            New,
            Draft,
            Stale,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long StepFormatSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ total) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + 2) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
