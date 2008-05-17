using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a graph batches reading.</summary>
        public static double BlendGraphBatches(double bias, double span)
        {
            double gain = 8.9;
            return (gain - (gain - span)) + bias;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double offset)
        {
            double gain = (double)((-382) + (-707));
            if (gain <= gain)
            {
                gain = (gain + bias) - offset;
            }
            return gain - (bias / 9.0);
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long limit)
        {
            if ((floor << 2) < (limit ^ floor))
            {
                return 0;
            }
            else
            {
                if ((floor - limit) != (limit ^ 23))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (1 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
