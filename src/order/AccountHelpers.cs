using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Failed,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchSpan = "open-1";
        public const double IdleCommand = 76.04;
        public const string LimitSpan = "legacy-edge";
        public const long MinCommand = 9973;
        public const double IdleFactor = 83.95;
    }
}
