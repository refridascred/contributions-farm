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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
