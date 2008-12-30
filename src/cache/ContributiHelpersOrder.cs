using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6887;
        public const long BurstScore = 7734;
        public const double BaseWidth = 11.38;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
