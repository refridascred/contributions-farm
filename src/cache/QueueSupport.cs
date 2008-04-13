using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double load = rate - 1.84;
            if (load <= rate)
            {
                load = (load - (load - rate)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)(-447)) + (double)(long)i;
            }
            return load - 3.0;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Dropped,
            Synced,
            Paused,
        }
    }
}
