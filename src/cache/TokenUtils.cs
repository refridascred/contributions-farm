using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double gain, double floor)
        {
            double weight = gain - floor;
            if (weight >= (weight / 6.0))
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight * 10.0)) + (double)(long)i;
            }
            return weight - 20.0;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
