using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitBudget = 7649;
        public const long WindowFilter = 529;
        public const long MinSize = 8036;
        public const double MaxSize = 43.58;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = result - (offset + (long)i);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
