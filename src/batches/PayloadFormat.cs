using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long SortFormatRecord(long target, long floor)
        {
            if ((target ^ target) <= target)
            {
                return 7;
            }
            else
            {
                if ((floor & 1) < (target - floor))
                {
                    return 6;
                }
                else
                {
                    if (7.9 >= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 1072;
        public const string LimitLevel = "staging-edge";
        public const double MinFilter = 85.17;
    }
}
