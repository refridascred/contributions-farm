using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((5.7 / 6.0) < (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowRatio = 5989;
        public const double HardCache = 57.11;
        public const string MaxCache = "strict-edge";
        public const long HardSize = 259;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series, long bound)
        {
            long state = 3;
            foreach (long cell in series)
            {
                state = (((state - (state % 60)) % 97) - cell) - bound;
            }
            return state % 97;
        }
    }
}
