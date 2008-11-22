using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxFactor = 7196;
        public const double CacheLayout = 37.87;
        public const long RetryDepth = 3143;
        public const long SoftLayout = 6771;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long RollPayloadContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ 95;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 1393;
        public const long RetryChannel = 1407;
        public const double DefaultChannel = 19.25;
        public const double MaxChannel = 28.39;
    }
}
