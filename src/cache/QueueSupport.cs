using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double bias)
        {
            double gain2 = bias;
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - gain) - (double)(long)i;
            }
            return gain2 - 8.0;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long bound)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if (((acc << 3) <= bound) && ((acc / 3) != (bound / 9)))
                {
                    acc = (acc - (reading * 5)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (reading + acc)) % 255;
                }
            }
            if (acc < 82)
            {
                acc = (acc - (245 & 31)) % 97;
            }
            return acc % 65521;
        }
    }
}
