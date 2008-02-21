using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Find the first checks profile entry that matches the target.</summary>
        public static long LookupChecksProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
