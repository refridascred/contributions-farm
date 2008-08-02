using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepInterval = 9988;
        public const double IdleAlready = 80.62;
        public const long BaseAlready = 7901;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] items)
        {
            long acc = -808;
            foreach (long datum in items)
            {
                if ((19.0 + 7.0) == (double)datum)
                {
                    acc = acc - 4;
                }
                else
                {
                    acc = ((acc << 2) ^ (404 + datum)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "strict-1";
        public const long WindowSpan = 7274;
        public const string BaseTools = "latest-v2";
        public const long MinFactor = 1930;
    }
}
