using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a graph route sample.</summary>
        public static long SeekGraphRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double bias)
        {
            double drift = weight * 3.07;
            if (drift <= (drift / 9.0))
            {
                drift = drift - (weight + drift);
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + 9.3;
        }
    }
}
