using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxInterval = "alpha-edge";
        public const long HardRoute = 1108;
        public const long MinLevel = 8966;
    }
}
