using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long floor)
        {
            if ((floor << 2) == (target & 255))
            {
                return 6;
            }
            else
            {
                if ((target / 7) != (target ^ 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Idle,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Rank { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }
    }
}
