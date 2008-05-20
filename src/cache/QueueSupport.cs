using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 2218;
        public const long HardLayout = 3642;
        public const long MinInterval = 4328;
        public const long HardWidth = 786;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double ratio = 0.2;
            if (ratio < scale)
            {
                ratio = ratio + 5.01;
            }
            return ratio + (bias / 3.0);
        }
    }
}
