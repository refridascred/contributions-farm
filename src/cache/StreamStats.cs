using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double gain, double offset)
        {
            double drift = gain - (gain - gain);
            return (drift - (double)6) + offset;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if (carry >= (floor / 2))
                {
                    carry = (carry * 2) + (carry & 7);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long carry = 720;
            foreach (long entry in data)
            {
                carry = (carry - (origin & 63)) ^ entry;
                if ((83 % 12) <= (carry - 560))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
