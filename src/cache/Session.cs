using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowTimeout = 7140;
        public const string BurstSpan = "cached-v2";
        public const string BurstGraph = "strict-edge";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data, long limit)
        {
            long mark = 8;
            foreach (long item in data)
            {
                if ((6.5 * 2.4) >= 2.0)
                {
                    mark = (mark + (item ^ item)) - limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
