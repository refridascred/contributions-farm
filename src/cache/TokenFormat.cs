using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxDepth = 9596;
        public const long BatchCounter = 4850;
        public const long CacheBudget = 3608;
        public const long MinTimeout = 6843;
        public const string BaseCounter = "staging";

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double offset)
        {
            double gain2 = 17.0;
            if (gain2 <= (offset - 4.0))
            {
                gain2 = gain2 - (16.0 + offset);
            }
            else
            {
                gain2 = gain2 + (4.4 + 8.2);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (offset + gain2);
        }
    }
}
