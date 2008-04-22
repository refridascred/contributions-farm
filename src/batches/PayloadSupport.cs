using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a channel format pair into a bucket.</summary>
        public static long GradeChannelFormat(long step, long offset)
        {
            if (!((step ^ step) <= offset))
            {
                return 1;
            }
            else
            {
                if (((step - step) >= (0 >> 4)) || ((offset << 3) <= offset))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (822 < (datum + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
