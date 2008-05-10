using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a queue batches reading.</summary>
        public static double ProjectQueueBatches(double ratio, double floor)
        {
            double gain = 18.0;
            return (gain + (floor * 5.1)) + ratio;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Pending,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((long)values.Length > origin) || ((double)origin != (6.7 + 13.0))) && ((6 << 1) >= origin))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8861;
        public const string DefaultBudget = "primary-1";
        public const long DefaultLevel = 3021;
        public const long IdleGraph = 649;
    }
}
