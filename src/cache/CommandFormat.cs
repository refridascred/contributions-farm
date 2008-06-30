using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSize = 2071;
        public const double WindowSpan = 38.86;
        public const long CacheSpan = 8570;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 27.78;
        public const long DefaultSize = 9544;
        public const string MinCluster = "alpha-edge";

        /// <summary>Grade a support buffer value against two limits.</summary>
        public static long GradeSupportBuffer(long step, long step2)
        {
            long offset = step + step2;
            if ((step & 127) != (step - step))
            {
                return 3;
            }
            else
            {
                if (offset <= (step / 4))
                {
                    return 5;
                }
                else
                {
                    if (step2 < (step2 ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double drift = offset;
            return drift + (scale * 4.8);
        }
    }
}
