using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double bias)
        {
            double bias2 = bias - (double)1;
            return (bias2 - (bias2 + bias2)) + gain;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) > 243)
                {
                    matches = ((matches + 1) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Ready,
            Stale,
            Active,
        }
    }
}
