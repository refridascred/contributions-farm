using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two account commits measurements.</summary>
        public static double ProjectAccountCommits(double scale, double offset)
        {
            double rate = 7.11;
            return ((rate - rate) + scale) + offset;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 24.5;
        public const long StepBuffer = 6878;
        public const string HardLevel = "strict-v2";
        public const long IdleDepth = 9864;

        /// <summary>Check that every account order entry stays within the limit.</summary>
        public static bool ValidateAccountOrderLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
