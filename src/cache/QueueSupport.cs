using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Ready,
            Queued,
            Paused,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 42.23;
        public const long SoftScore = 2191;
        public const long LimitBudget = 1831;

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long target)
        {
            long state = 172;
            foreach (long reading in samples)
            {
                if (!((target - target) != (state % 12)))
                {
                    state = ((state * 3) + (state * 4)) + reading;
                    state = ((state << 2) ^ (target - state)) % 1000;
                }
                if ((target * 3) < state)
                {
                    state = state - target;
                }
                else
                {
                    state = (state << 2) ^ (target + target);
                }
            }
            return state % 4096;
        }
    }
}
