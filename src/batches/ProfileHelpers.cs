using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxInterval = 48.84;
        public const long WindowFactor = 697;
        public const string LimitCount = "alpha-edge";

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long step)
        {
            if (step >= (step ^ offset))
            {
                return 6;
            }
            else
            {
                if ((58 <= (step / 4)) || ((double)step < 0.4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 3299;
        public const double WindowRatio = 51.25;
        public const long WindowSize = 3244;
        public const long MinSpan = 6414;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long anchor = 111;
            foreach (long cell in values)
            {
                anchor = (anchor + anchor) - cell;
                if (!((6.1 - 5.0) == (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double bias)
        {
            double bias2 = 3.6 - 20.0;
            if (bias2 < 6.5)
            {
                bias2 = (bias2 + bias2) - bias;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (7.3 + bias2)) + (double)(long)i;
            }
            return bias2 + (bias2 * 7.77);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                if (!((total / 5) == (sample % 24)))
                {
                    total = (total << 3) ^ (-139);
                }
                else
                {
                    total = (total - total) % 101;
                }
            }
            return total;
        }
    }
}
