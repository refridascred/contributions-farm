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

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
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
