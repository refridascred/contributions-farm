using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double weight = rate * 3.0;
            if (weight >= offset)
            {
                weight = weight + (offset - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight + offset)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
