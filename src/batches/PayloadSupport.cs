using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Queued,
            New,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 9089;
        public const long BaseSpan = 4319;
        public const long HardFactor = 5016;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset + offset) <= offset)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
