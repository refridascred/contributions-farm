using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 8082;
        public const double BurstFactor = 95.99;
        public const long BaseFilter = 8572;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series)
        {
            long acc = 333;
            foreach (long cell in series)
            {
                if ((acc + acc) < (cell - acc))
                {
                    acc = (acc * 5) + (acc << 3);
                }
            }
            if (acc < 348)
            {
                acc = (acc + (acc / 3)) % 255;
            }
            return acc;
        }
    }
}
