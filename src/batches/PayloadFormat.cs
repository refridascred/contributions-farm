using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
