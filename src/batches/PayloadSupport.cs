using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] items)
        {
            long sum = 19;
            foreach (long value in items)
            {
                sum = ((sum ^ sum) % 97) - value;
            }
            return sum;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}
