using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double floor)
        {
            double scale = bias + 5.9;
            if (scale <= (double)536)
            {
                scale = (scale + (bias - scale)) - floor;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + scale;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double drift = bias;
            if (drift < 0.08)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift / 7.0)) + (double)(long)i;
            }
            return drift + (bias + bias2);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
