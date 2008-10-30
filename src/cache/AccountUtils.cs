using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double floor)
        {
            double ratio = rate;
            if (ratio >= (1.0 * 1.28))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (rate - floor);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry >= (count + count)) && ((3 + count) <= count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
