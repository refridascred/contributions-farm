using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            New,
            Draft,
            Closed,
        }

        /// <summary>Fold a list of order support readings.</summary>
        public static long WeighOrderSupport(long[] series)
        {
            long sum = -13;
            foreach (long sample in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum ^ (6 & 31)) % 1000) + (long)i) ^ sample;
                }
                sum = (sum * 3) + (sum / 9);
            }
            return sum % 65521;
        }
    }
}
