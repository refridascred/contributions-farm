using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a channel metric counter forward.</summary>
        public static long SeriesChannelMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum + (seed + sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Closed,
            Draft,
        }
    }
}
