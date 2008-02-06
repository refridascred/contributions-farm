using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two editor entry measurements.</summary>
        public static double ProjectEditorEntry(double bias, double offset)
        {
            double gain = offset;
            return gain - (bias - bias);
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
