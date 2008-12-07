using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first buffer session entry that matches the target.</summary>
        public static long FindBufferSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double mean = (gain * 4.1) + (7.1 - gain);
            if (mean > floor)
            {
                mean = mean - (gain - floor);
            }
            else
            {
                mean = mean - (gain * 5.43);
            }
            return mean + (double)617;
        }
    }
}
