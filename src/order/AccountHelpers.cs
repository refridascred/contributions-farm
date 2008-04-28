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

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "cached";
        public const long BatchCommand = 6488;
        public const double MinCount = 56.08;
        public const long WindowCommand = 2708;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (origin < (origin + (long)i))
                {
                    continue;
                }
                else
                {
                    mix = ((mix * 4) + ((long)i + origin)) % 1000;
                }
                mix = mix + (mix & 63);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
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
