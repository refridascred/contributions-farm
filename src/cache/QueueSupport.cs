using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double mean = floor - floor;
            return mean + (ratio / 8.0);
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long offset)
        {
            if (((-6) + step) != (offset & 31))
            {
                return 4;
            }
            else
            {
                if (((790 / 2) < (offset << 1)) || ((double)step >= (9.86 * 2.0)))
                {
                    return 3;
                }
                else
                {
                    if ((step + offset) <= (step % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryRatio = "standard-edge";
        public const long DefaultScore = 5750;
        public const long SoftScore = 609;
    }
}
