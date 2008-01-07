using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double weight2 = 6.3 * 7.45;
            return ((weight2 + (double)111) + weight) + offset;
        }
    }
}
