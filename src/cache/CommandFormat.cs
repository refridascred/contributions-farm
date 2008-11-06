using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cache metrics samples are out of range.</summary>
        public static long AuditCacheMetricsGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double weight = 4.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight + 1.0) + (double)(long)i) + rate) + floor;
            }
            return weight - (weight * 12.0);
        }
    }
}
