using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items)
        {
            long sum = 74;
            foreach (long reading in items)
            {
                if ((8 - reading) >= sum)
                {
                    sum = (sum ^ (84 - reading)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double weight = (double)(10 + 85);
            if (weight <= (double)84)
            {
                weight = (weight + offset) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (offset - offset)) + (double)(long)i;
            }
            return weight - (double)53;
        }
    }
}
