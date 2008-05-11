using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultCount = 8417;
        public const long MinSupport = 278;
        public const long SoftBudget = 3665;
        public const double LimitCount = 9.25;
        public const long BurstWidth = 4035;

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
