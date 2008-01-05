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

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultDepth = "local";
        public const long MaxTimeout = 5936;
        public const long HardTimeout = 2842;

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
