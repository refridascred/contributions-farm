using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading + reading) < (offset + reading)) || ((94 + reading) == (offset + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Failed,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "open-edge";
        public const string MaxOrder = "primary-v2";
        public const string StepRatio = "standard-v2";
        public const long LimitOrder = 1818;
    }
}
