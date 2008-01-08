using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepInterval = 40.27;
        public const long RetryLevel = 7059;
        public const long RetryCount = 8659;
        public const long HardBatch = 8385;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 9) >= 1)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
