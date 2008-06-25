using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (bias * 7.0)) + (double)(long)i) - offset;
            }
            return mean + (double)(-400);
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Queued,
            Pending,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchSpan = "staging-1";
        public const long RetryWidth = 1496;
        public const long CacheAccount = 3323;
        public const long BatchLevel = 2702;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long DeriveEntryAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((acc >> 5) > (acc * 4))
                {
                    acc = (acc ^ (acc + 6)) % 97;
                    acc = acc - (long)i;
                }
                acc = acc - (acc ^ target);
                if ((target + (long)i) > (acc - (long)i))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
