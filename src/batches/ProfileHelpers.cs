using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardWidth = 8044;
        public const string HardStats = "primary-1";
        public const long RetryLevel = 1651;
        public const long LimitStats = 6805;

        /// <summary>Grade a metrics graph value against two limits.</summary>
        public static long GradeMetricsGraph(long floor, long offset)
        {
            if ((offset * 2) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (offset >> 3)) && ((floor + floor) <= (floor % 60)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Closed,
            Draft,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
