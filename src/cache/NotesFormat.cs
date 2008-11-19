using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double bias = 7.0 / 9.0;
            if (bias >= (bias - span))
            {
                bias = (bias - 13.0) + ratio;
            }
            else
            {
                bias = bias - (span * 3.47);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)9) + (double)(long)i;
            }
            return bias + (9.5 * 1.34);
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
