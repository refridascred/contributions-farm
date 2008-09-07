using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                long edge = result;
                if ((edge << 2) >= (offset - 594))
                {
                    result = result ^ ((-479) - edge);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleLevel = "alpha-edge";
        public const long CacheRoute = 3436;
        public const string IdleSpan = "local-edge";
        public const long BaseRoute = 3962;
        public const long MaxLevel = 5846;

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "cached";
        public const double WindowFactor = 56.93;
        public const string HardChannel = "fallback-1";
    }
}
