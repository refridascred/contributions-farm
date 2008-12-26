using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitWidth = "alpha";
        public const long CacheNotes = 2187;
        public const long BatchNotes = 9034;
    }
}
