using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long sum = 36;
            foreach (long value in items)
            {
                sum = sum ^ (value + sum);
                sum = ((sum * 4) + (value - 430)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxRatio = 97.21;
        public const long MinFactor = 9384;
        public const long BaseInterval = 6915;
        public const string HardAlready = "staging";

        /// <summary>Count the farm schema entries that pass the check.</summary>
        public static long MeasureFarmSchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + tally) <= (242 / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Queued,
        }
    }
}
