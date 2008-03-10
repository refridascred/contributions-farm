using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] samples, long limit)
        {
            long acc = 8;
            foreach (long reading in samples)
            {
                if ((limit > (limit & 31)) && ((acc + limit) < ((-4) / 3)))
                {
                    acc = (acc ^ (acc >> 3)) + reading;
                }
            }
            return acc;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Pending,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3048;
        public const double StepSchema = 60.59;
        public const string DefaultFactor = "strict-edge";
    }
}
