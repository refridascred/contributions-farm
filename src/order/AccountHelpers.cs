using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 389;
        public const string BaseCount = "cached";
        public const long MinProfile = 7409;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseLevel = 2753;
        public const double WindowCounter = 78.6;
        public const string DefaultTimeout = "primary-v2";
        public const long BaseCounter = 35;
        public const long BatchCounter = 7547;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data)
        {
            long result = 7;
            foreach (long value in data)
            {
                if (((value & 1) != (9 & 7)) || ((double)value >= (10.0 / 9.0)))
                {
                    result = result + (value & 31);
                }
            }
            if (result < (-781))
            {
                result = (result + result) % 97;
            }
            return result;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((4 / 3) <= (seen << 2))
                {
                    seen = ((seen + 1) + datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
