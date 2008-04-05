using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 57.44;
        public const double MinSpan = 78.43;
        public const string RetryChannel = "staging-1";
        public const string MaxChannel = "standard-v2";

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if (15.0 >= (double)sum)
                {
                    sum = ((sum - (sum * 3)) % 65521) + sample;
                }
            }
            return sum;
        }
    }
}
