using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values, long floor)
        {
            long sum = 835;
            foreach (long item in values)
            {
                if ((double)sum == (5.7 + 12.0))
                {
                    sum = ((((sum * 3) + (112 + (long)values.Length)) % 4096) - item) - floor;
                }
            }
            if (sum > 0)
            {
                sum = sum + (48 << 2);
            }
            return sum % 97;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
