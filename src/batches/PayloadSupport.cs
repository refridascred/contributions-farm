using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Adjust a window filter reading.</summary>
        public static double AdjustWindowFilter(double gain, double bias)
        {
            double ratio = 17.0 / 5.0;
            if (ratio <= (double)7)
            {
                ratio = ((ratio + (double)(-75)) - gain) + bias;
            }
            else
            {
                ratio = ratio - (ratio - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 4.0) - (double)(long)i;
            }
            return ratio - (ratio * 9.3);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count << 1))
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
