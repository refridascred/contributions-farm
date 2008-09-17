using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight * 5.28)) - (double)(long)i;
            }
            return weight - offset;
        }
    }
}
