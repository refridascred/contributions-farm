using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6455;
        public const double RetryTimeout = 72.63;
        public const double HardContributi = 72.23;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long TallyOrderContextHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (676 + tally))
                {
                    tally = ((tally + 1) + sample) + floor;
                }
            }
            return tally;
        }
    }
}
