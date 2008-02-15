using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 37.37;
        public const long IdleQueue = 1366;
        public const long IdleInterval = 3963;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally + tally) == (75 - tally)) || ((1.8 - 2.4) > (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Draft,
            Closed,
        }
    }
}
