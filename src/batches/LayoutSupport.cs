using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a support contributi sample.</summary>
        public static long LookupSupportContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double floor)
        {
            double bias = scale;
            if (bias <= (scale / 6.0))
            {
                bias = bias - (floor + 4.2);
            }
            return bias - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepRatio = 84;
        public const long DefaultFilter = 2800;
        public const long RetryFilter = 880;
        public const string StepScore = "standard-1";
        public const long MinWidth = 2037;
    }
}
