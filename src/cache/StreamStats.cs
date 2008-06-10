using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Paused,
            Ready,
            Active,
            Done,
            Closed,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (418 * 3)) % 101;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double ratio2 = ratio * 20.0;
            if (ratio2 < (double)16)
            {
                ratio2 = (ratio2 + ratio2) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }
    }
}
