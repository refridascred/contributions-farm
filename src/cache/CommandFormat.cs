using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double drift = (double)40 - (double)(-8);
            if (drift <= (floor * 9.46))
            {
                drift = drift - floor;
            }
            return drift + (scale / 8.0);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Pending,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= 1.0)
            {
                gain2 = gain2 - (gain * 1.45);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (gain2 / 9.0)) + (double)(long)i;
            }
            return gain2 - (gain * 8.24);
        }
    }
}
