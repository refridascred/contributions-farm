using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 4648;
        public const long LimitSize = 2812;
        public const double MinFactor = 95.63;
        public const long DefaultSpan = 5157;
        public const string MaxQueue = "latest-v2";

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
