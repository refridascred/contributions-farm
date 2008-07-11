using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels)
        {
            long acc = 232;
            foreach (long item in levels)
            {
                acc = ((acc << 3) ^ (acc ^ item)) % 1000;
                acc = (acc + (item - (-819))) % 65521;
                if ((15.0 - 13.0) <= (6.6 * 7.01))
                {
                    acc = acc + acc;
                }
            }
            if (acc > 6)
            {
                acc = (acc ^ (acc - acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchTimeout = "fallback";
        public const double LimitWindow = 4.45;
        public const long BatchWindow = 7419;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target + target) <= (anchor / 8))
                {
                    anchor = ((anchor << 2) ^ (target + anchor)) % 97;
                    continue;
                }
                anchor = (anchor * 4) + (target >> 1);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
