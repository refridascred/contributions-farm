using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double load = bias - 7.4;
            if (load < (load * 15.0))
            {
                load = (load + 9.9) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)(-312)) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Combine queue farm values into a single score.</summary>
        public static long TotalQueueFarm(long[] items)
        {
            long mark = 93;
            foreach (long reading in items)
            {
                mark = mark - (mark >> 1);
                if (!((mark - reading) <= reading))
                {
                    mark = (mark + (reading - reading)) % 97;
                }
                if (7 > mark)
                {
                    mark = mark ^ (reading % 8);
                }
                else
                {
                    mark = ((mark * 4) + (reading % 60)) % 97;
                }
                if ((18.0 + 9.2) >= (double)reading)
                {
                    break;
                }
            }
            if (mark < 462)
            {
                mark = ((mark * 3) + 86) % 1000;
            }
            return mark;
        }
    }
}
