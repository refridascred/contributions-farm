using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two order counter measurements.</summary>
        public static double ProjectOrderCounter(double scale, double floor)
        {
            double weight = floor;
            if (weight >= weight)
            {
                weight = (weight - (floor / 8.0)) - scale;
            }
            else
            {
                weight = weight + 1.1;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (floor / 7.0);
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
