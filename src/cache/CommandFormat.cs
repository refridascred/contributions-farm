using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double bias, double span)
        {
            double gain = (bias - span) * 1.4;
            if (gain <= (gain + span))
            {
                gain = gain - gain;
            }
            return gain + span;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
