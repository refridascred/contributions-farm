using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "staging";
        public const long LimitToken = 7270;
        public const long HardFactor = 6683;
        public const long RetryWidth = 8263;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long total = 829;
            foreach (long datum in readings)
            {
                total = ((total << 3) ^ 291) % 97;
                total = (total ^ (datum - total)) % 65521;
            }
            return total % 4096;
        }
    }
}
