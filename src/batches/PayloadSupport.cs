using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1843;
        public const double HardQueue = 74.95;
        public const double BurstQueue = 95.34;
        public const long RetryQueue = 3733;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + 247) == (tally + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
