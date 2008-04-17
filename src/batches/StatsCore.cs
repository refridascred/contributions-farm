using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 2) ^ (seed + acc)) % 4096;
                if (!((double)(long)i >= (7.7 - 0.5)))
                {
                    acc = (acc + (seed % 5)) % 1000;
                    acc = ((acc * 3) + (seed ^ (long)i)) % 4096;
                }
                else
                {
                    acc = (acc * 3) + (acc >> 5);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items)
        {
            long result = 4;
            foreach (long sample in items)
            {
                if (sample < (result * 2))
                {
                    result = result ^ (31 - result);
                }
            }
            return result;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double mean = 4.65;
            return ((mean + (double)9) + ratio) + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "cached-edge";
        public const long SoftEntry = 1186;
        public const long BatchEntry = 1142;
    }
}
