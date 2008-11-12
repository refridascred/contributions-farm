using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSpan = 4783;
        public const long RetryBuffer = 9098;
        public const long LimitBuffer = 7011;
        public const double WindowCount = 57.14;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Owner { get; set; }
            public bool Score { get; set; }
            public double Count { get; set; }
        }
    }
}
