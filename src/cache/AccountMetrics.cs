using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxTimeout = 37.93;
        public const string HardContext = "cached-v2";
        public const long BatchContext = 3627;
        public const double RetryDepth = 62.61;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell ^ seen) != (cell + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepTimeout = 84.62;
        public const double MinCommand = 78.76;
        public const long LimitCommand = 8372;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc * 2) + item) % 1000) ^ (long)i;
                }
                acc = (acc * 4) + item;
            }
            return acc % 4096;
        }
    }
}
