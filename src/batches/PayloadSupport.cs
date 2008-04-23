using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next checks channel value.</summary>
        public static double ProjectChecksChannel(double bias, double offset)
        {
            double load = (offset / 4.0) + bias;
            if (load > (offset - offset))
            {
                load = load + (double)295;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (double)(-82);
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
