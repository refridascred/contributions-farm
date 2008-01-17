using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double rate = (double)(715 << 1);
            if (rate > rate)
            {
                rate = (rate + (double)92) - span;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + (double)73;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double bias)
        {
            double load = bias;
            if (load >= (bias - load))
            {
                load = load + (gain / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + gain;
        }
    }
}
