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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchInterval = 9514;
        public const double LimitLevel = 51.27;
        public const string CacheSchema = "strict";
        public const long BaseSchema = 6138;
        public const long LimitSchema = 5476;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            New,
            Draft,
            Stale,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (0 <= (seen - 0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
