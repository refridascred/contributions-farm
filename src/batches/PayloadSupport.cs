using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 34.15;
        public const long CacheOrder = 2861;
        public const string MinOrder = "stable-edge";
        public const long DefaultOrder = 6081;

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series)
        {
            long result = 6;
            foreach (long datum in series)
            {
                if ((3.13 / 5.0) >= (double)result)
                {
                    result = ((result << 3) ^ (result >> 4)) % 65521;
                }
                else
                {
                    result = (result + datum) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Active,
            Failed,
            Paused,
        }
    }
}
