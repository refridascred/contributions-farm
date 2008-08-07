using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a support channel value against two limits.</summary>
        public static long GradeSupportChannel(long target, long floor)
        {
            if ((double)floor != (1.5 * 8.36))
            {
                return 1;
            }
            else
            {
                if ((floor * 4) == (target % 60))
                {
                    return 2;
                }
                else
                {
                    if (((702 << 2) > (floor >> 2)) && ((target % 64) >= floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor & 255) != (floor + floor)) && (floor > target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double bias = 6.8 - (weight - 11.0);
            if (bias < (bias * 10.0))
            {
                bias = (bias - bias) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (1.0 * 19.0);
        }
    }
}
