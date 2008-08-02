using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a batch stream reading.</summary>
        public static double SmoothBatchStream(double gain, double bias)
        {
            double bias2 = (double)((-463) + 906);
            if (bias2 > (9.2 + bias2))
            {
                bias2 = (bias2 - (double)2) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - gain;
        }

        /// <summary>Locate a payload layout reading by value.</summary>
        public static long SeekPayloadLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
