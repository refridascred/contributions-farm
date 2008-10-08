using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "primary-edge";
        public const long DefaultOrder = 3145;
        public const double BatchWidth = 30.59;
        public const string BurstOrder = "fallback-v2";

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Locate a format payload reading by value.</summary>
        public static long FindFormatPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
